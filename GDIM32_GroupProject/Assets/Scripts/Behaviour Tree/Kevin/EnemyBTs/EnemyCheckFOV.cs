using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;


public class EnemyCheckFOV : KevNode
{
    private static int _unitLayerMask = 1 << 7;
    private float FOVRange;

    private Transform _transform;
    //  private Animator _animator;

    public EnemyCheckFOV(Transform transform, float FOV)
    {
        _transform = transform;
        FOVRange = FOV;
        // _animator = transform.GetComponent<Animator>();
    }

    public override NodeState Evaluate()
    {
        object t = GetData("target");
        if (t == null)
        {
            Collider2D colliders = Physics2D.OverlapCircle(
                _transform.position, FOVRange, _unitLayerMask);

            if (colliders != null)
            {
                Debug.Log("Enemy checking for target; FOUND: " + colliders);
                parent.parent.SetData("target", colliders.transform);
                // _animator.SetBool("Walking", true);
                state = NodeState.SUCCESS;
                return state;
            }
            Debug.Log("Checking for target; FAILED");
            state = NodeState.FAILURE;
            return state;
        }

        state = NodeState.SUCCESS;
        return state;
    }
}
