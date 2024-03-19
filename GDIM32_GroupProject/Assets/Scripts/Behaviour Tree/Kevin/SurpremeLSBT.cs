using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class SurpremeLSBT : BehaviorTree.Tree
{

    public UnityEngine.Transform waypoint;
    private static float speed = 4f;
    private static float attackRange = 2.2f;
    public static float FOVRange = 6f;
    private static int UnitDmg = 7;

    public SurpremeLSBT(float attackrange, float speed)
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
                new TaskAttack(transform, UnitDmg),
            }),
            new Sequence(new List<KevNode>
            {
                new CheckFOVRange(transform, FOVRange),
                new GoToTarget(transform, speed),
            }),
            new Walk(transform, waypoint, speed),
        });

        return root;
    }
}
