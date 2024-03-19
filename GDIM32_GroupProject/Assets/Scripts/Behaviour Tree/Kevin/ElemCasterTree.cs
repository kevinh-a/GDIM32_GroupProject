using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class ElumCasterTree : BehaviorTree.Tree
{
    public UnityEngine.Transform waypoint;
    private static float speed = 1f;
    private static float attackRange = 4f;
    public static float FOVRange = 10f;
    private static int UnitDmg = 25;

    public ElumCasterTree(float attackrange, float speed)
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
                new CheckInAttackRng(transform, attackRange),
                new Cast(transform, UnitDmg),
                new TaskAttack(transform, UnitDmg),
            }),
            new Sequence(new List<KevNode>
            {
                new CheckFOVRange(transform),
                new GoToTarget(transform, speed),
            }),
            new Walk(transform, waypoint, speed),
        });

        return root;
    }
}
