using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using BehaviorTree;
public class CheckForTargets : Node
{
    //Tutorial :https://www.youtube.com/watch?v=aR6wt5BlE-E
    private static int _enemyLayerMask = 1 << 6;

    private Transform _transform;
    private Animator _animator;

    public CheckForTargets(Transform transform)
    {
        _transform = transform;
        _animator = transform.GetComponent<Animator>();
    }
    /*
    public override NodeState Evaluate()
    {
        object t = GetData("target");
        if(t == null)
        {
            state = NodeState.FAILURE;
            return state;
        }

        Transform target = (Transform)t;
        if(Vector2.Distance(_transform.position, target.position) <= )
        {
            _animator.SetBool("Attack", true);
            _animator.SetBool("Walking", false)

            if = NodeState.SUCCESS;
            return state;
        }

        state = NodeState.FAILURE;
        return state;
    }*/
}