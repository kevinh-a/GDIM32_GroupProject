using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckInAttackRng : KevNode
{

    private Transform _transform;
    //private Animator _animator;
    private float _attackRange;

    public CheckInAttackRng(Transform transform, float attackRange)
    {
        _transform = transform;
        _attackRange = attackRange;
        //_animator = transform.GetComponent<Animator>();
    }

    public override NodeState Evaluate()
    {
        object t = GetData("target");
        if (t == null)
        {
            state = NodeState.FAILURE;
            return state;
        }

        Transform target = (Transform)t;
        try
        {
            if (Vector2.Distance(_transform.position, target.position) <= _attackRange)
            {
                // _animator.SetBool("Attacking", true);
                // _animator.SetBool("Walking", false);
                Debug.Log("CheckInAttackRng's " + target);
                state = NodeState.SUCCESS;
                return state;
            }
        }
        catch
        {
            state = NodeState.FAILURE;
            return state;
        }
        state = NodeState.FAILURE;
        return state;
    }
}
