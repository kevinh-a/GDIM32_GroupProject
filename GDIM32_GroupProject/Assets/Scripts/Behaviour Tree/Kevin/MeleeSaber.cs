using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class MeleeSaber : BehaviorTree.Tree
{
    public UnityEngine.Transform waypoint;
    public static float speed = 2f;
    public static float attackRange = 2f;
    public static float FOVRange = 6f;
    public static int UnitDmg = 5;

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
                new CheckInAttackRng(transform),
                new TaskAttack(transform, 5),
            }),
            new Sequence(new List<KevNode>
            {
                new CheckFOVRange(transform),
                new GoToTarget(transform),
            }),
            new Walk(transform, waypoint),
        });

        return root;
    }
}
