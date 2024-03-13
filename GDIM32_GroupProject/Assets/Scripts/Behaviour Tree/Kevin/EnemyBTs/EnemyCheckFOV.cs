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
            Collider[] colliders = Physics.OverlapSphere(
                _transform.position, FOVRange, _unitLayerMask);

            if (colliders.Length > 0)
            {
                Debug.Log("Enemy checking for target; FOUND");
                parent.parent.SetData("target", colliders[0].transform);
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
