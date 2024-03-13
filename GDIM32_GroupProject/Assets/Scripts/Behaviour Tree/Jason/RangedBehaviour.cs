using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    BehaviourTree tree;
    public GameObject boss;
    public GameObject waypoint;
    NavMeshAgent agent;

    public enum ActionState { IDLE, WORKING };
    ActionState state = ActionState.IDLE;

    Node.Status treeStatus = Node.Status.RUNNING;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        tree = new BehaviourTree();
        Sequence walk = new Sequence("Walking");
        Leaf waypoint = new Leaf("Waypoint", Waypoint);
        Leaf target = new Leaf("Target Enemy", Target);
        Leaf attack = new Leaf("Attack Enemy", Attack);

        walk.AddChild(waypoint);
        walk.AddChild(target);
        walk.AddChild(attack);
        tree.AddChild(walk);

        tree.PrintTree();

      


    }

    public Node.Status Waypoint()
    {
        return GoToLocation(waypoint.transform.position);
    }

    public Node.Status Target()
    {
        return GoToLocation(boss.transform.position);
    }
    //figure out how to do attack later
    public Node.Status Attack()
    {
        return GoToLocation(boss.transform.position);
    }


    Node.Status GoToLocation(Vector2 destination)
    {
        float distanceToTarget = Vector2.Distance(destination, this.transform.position);
        if (state == ActionState.IDLE)
        {
            agent.SetDestination(destination);
            state = ActionState.WORKING;
        }
        else if (Vector3.Distance(agent.pathEndPosition, destination) >= 7)
        {
            state = ActionState.IDLE;
            return Node.Status.FAILURE;
        }
        else if (distanceToTarget < 7)
        {
            state = ActionState.IDLE;
            return Node.Status.SUCCESS;
        }
        return Node.Status.RUNNING;
    }

    // Update is called once per frame
    void Update()
    {
        if(treeStatus == Node.Status.RUNNING)
        treeStatus = tree.Process();
    }
}
