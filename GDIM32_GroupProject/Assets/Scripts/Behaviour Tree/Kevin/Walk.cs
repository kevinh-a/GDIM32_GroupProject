using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class Walk : KevNode
{
    private Transform _transform;
    private Transform _waypoint;

    public Walk(Transform transform, Transform waypoint)
    {
        _transform = transform;
        _waypoint = waypoint;
    }

    public override NodeState Evaluate()
    {
        _transform.position = Vector2.MoveTowards(_transform.position, _waypoint.position, MeleeSaber.speed * Time.deltaTime);
        state = NodeState.RUNNING;
        return state;
    }
}
