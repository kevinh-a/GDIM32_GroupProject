using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;
public class CheckForTargets : KevNode
{
    //Tutorial :https://www.youtube.com/watch?v=aR6wt5BlE-E

    private Transform _transform;
    //private Animator _animator;
    //private float AttkRange;

    public CheckForTargets(Transform transform)
    {
        _transform = transform;
       // _animator = transform.GetComponent<Animator>();
        Debug.Log("Checking for target");
    }


    public override NodeState Evaluate()
    {

        object t = GetData("target");
        if(t == null)
        {
            state = NodeState.FAILURE;
            return state;
        }

        Transform target = (Transform)t;
        if(Vector2.Distance(_transform.position, target.position) <= unit.AttackRange)
        {
           // _animator.SetBool("Attack", true);
           // _animator.SetBool("Walking", false);

            state = NodeState.SUCCESS;
            return state;
        }

        state = NodeState.FAILURE;
        return state;
    }
}
