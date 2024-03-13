using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;
public class EnemyTaskAttck : KevNode
{
    private int dmg;

    // private Animator _animator;
    private Transform _lastTarget;
    private CharacterBase charBase;

    private float _attackTime = 1f;
    private float _attackCounter = 0f;

    public EnemyTaskAttck(Transform transform, int unitDmg)
    {
        //_animator = transform.GetComponent<Animator>;
        dmg = unitDmg;

    }

    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");

        if (target != _lastTarget)
        {
            charBase = target.GetComponent<CharacterBase>();
            _lastTarget = target;
        }

        _attackCounter += Time.deltaTime;
        if (_attackCounter >= _attackTime)
        {
            charBase.TakeDmg(dmg);
            if (charBase == null)
            {
                ClearData("target");
                // _animator.SetBool("Attacking", false);
                // _animator.SetBool("Walking", true);
            }
            else
            {
                _attackCounter = 0f;
            }
        }
        state = NodeState.RUNNING;
        return state;
    }
}
