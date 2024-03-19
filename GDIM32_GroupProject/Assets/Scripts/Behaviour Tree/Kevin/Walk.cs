using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class Walk : KevNode
{
    private Transform _transform;
    private Transform _waypoint;
    private float _speed;

    public Walk(Transform transform, Transform waypoint, float speed)
    {
        _transform = transform;
        _waypoint = waypoint;
        _speed = speed;
    }

    public override NodeState Evaluate()
    {
        if (_waypoint != null)
        {
            _transform.position = Vector2.MoveTowards(_transform.position, _waypoint.position, _speed * Time.deltaTime);
            state = NodeState.RUNNING;
            return state;
        }
        state = NodeState.RUNNING;
        return state;
    }
}
