using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;


public class CheckFOVRange : KevNode
{
    private static int _enemyLayerMask = 1 << 6;

    private Transform _transform;
  //  private Animator _animator;

    public CheckFOVRange(Transform transform)
    {
        _transform = transform;
       // _animator = transform.GetComponent<Animator>();
    }

    public override NodeState Evaluate()
    {
        object t = GetData("target");
        if (t == null)
        {
            Collider[] colliders = Physics.OverlapSphere(
                _transform.position, MeleeSaber.FOVRange, _enemyLayerMask);

            if (colliders.Length > 0)
            {
                //Debug.Log("Checking for target; FOUND");
                parent.parent.SetData("target", colliders[0].transform);
               // _animator.SetBool("Walking", true);
                state = NodeState.SUCCESS;
                return state;
            }
            //Debug.Log("Checking for target; FAILED");
            state = NodeState.FAILURE;
            return state;
        }

        state = NodeState.SUCCESS;
        return state;
    }
}
