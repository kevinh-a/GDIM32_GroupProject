using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class EnemyCommon : BehaviorTree.Tree
{

    public UnityEngine.Transform waypoint;
    private static float speed = 3f;
    private static float attackRange = 2f;
    public static float FOVRange = 12f;
    private static int UnitDmg = 5;

    public EnemyCommon(float attackrange, float speed)
    {
        //this.speed = speed;
        //this.attackRange = attackrange;

    }

    protected override KevNode SetupTree()
    {

        KevNode root = new Selector(new List<KevNode>
        {
            new Sequence(new List<KevNode>
            {
                new EnemyAttackRange(transform, attackRange),
                new EnemyTaskAttck(transform, UnitDmg),
            }),
            new Sequence(new List<KevNode>
            {
                new EnemyCheckFOV(transform, FOVRange),
                new EnemyGoToTarget(transform, speed),
            }),
            new Walk(transform, waypoint, speed),
        });

        return root;
    }
}
