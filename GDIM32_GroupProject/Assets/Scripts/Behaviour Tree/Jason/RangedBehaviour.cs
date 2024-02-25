using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    BehaviourTree tree;


    // Start is called before the first frame update
    void Start()
    {
        tree = new BehaviourTree();
        Node walk = new Node("Walking");
        Node target = new Node("Target Enemy");
        Node attack = new Node("Attack Enemy");

        walk.AddChild(target);
        walk.AddChild(attack);
        tree.AddChild(walk);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
