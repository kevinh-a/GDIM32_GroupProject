using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;
public class Cast : KevNode
{
    private int dmg;

    // private Animator _animator;
    private Transform _lastTarget;
    private EnemyBase enemyBase;

    private float _CastTime = 3f;
    private float _attackCounter = 0f;

    public Cast(Transform transform, int unitDmg)
    {
        //_animator = transform.GetComponent<Animator>;
        dmg = unitDmg;

    }

    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");

        if (target != _lastTarget)
        {
            enemyBase = target.GetComponent<EnemyBase>();
            _lastTarget = target;
        }

        //Add an IENumerator for waiting
        state = NodeState.RUNNING;
        return state;
    }
}
