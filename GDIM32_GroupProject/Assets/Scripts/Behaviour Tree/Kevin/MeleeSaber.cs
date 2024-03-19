using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class MeleeSaber : BehaviorTree.Tree
{
    
    public UnityEngine.Transform waypoint;
    private static float speed = 3f;
    private static float attackRange = 2f;
    public static float FOVRange = 12f;
    private static int UnitDmg = 5;

    public MeleeSaber(float attackrange, float speed)
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
                new CheckFOVRange(transform),
                new GoToTarget(transform, speed),
            }),
            new Walk(transform, waypoint, speed),
        });

        return root;
    }
}
