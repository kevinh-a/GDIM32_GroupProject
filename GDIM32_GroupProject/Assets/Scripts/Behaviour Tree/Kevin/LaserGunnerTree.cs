using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class LaserGunnerTree : BehaviorTree.Tree
{
    public UnityEngine.Transform waypoint;
    private static float speed = 1.8f;
    private static float attackRange = 4.6f;
    private static float FOVRange = 6f;
    private static int UnitDmg = 3;

    public LaserGunnerTree(float attackrange, float speed)
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
