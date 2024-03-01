using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;
public class GoToTarget : KevNode
{
    private Transform _transform;

    public GoToTarget(Transform transform)
    {
        _transform = transform;
    }

    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");
        Debug.Log("Going To target");

        if (Vector2.Distance(_transform.position, target.position) > 0.01f)
        {
            _transform.position = Vector2.MoveTowards(
                _transform.position, target.position, MeleeSaber.speed * Time.deltaTime);
            //_transform.LookAt(target.position);
        }

        state = NodeState.RUNNING;
        return state;
    }
}
