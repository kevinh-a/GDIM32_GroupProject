using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;
public class EnemyGoToTarget : KevNode
{
    private Transform _transform;
    private float _speed;

    public EnemyGoToTarget(Transform transform, float speed)
    {
        _transform = transform;
        _speed = speed;
    }

    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");
        //Debug.Log("Going To target");
        if (target == null)
        {
            Debug.Log("Go To target's " + target);
            ClearData("target");
            state = NodeState.FAILURE;
            return state;
        }
        else
        {
            if (Vector2.Distance(_transform.position, target.position) > 0.01f)
            {
                _transform.position = Vector2.MoveTowards(
                    _transform.position, target.position, _speed * Time.deltaTime);
                //_transform.LookAt(target.position);
            }
        }

        state = NodeState.RUNNING;
        return state;
    }
}
