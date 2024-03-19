using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TurretTree : BehaviorTree.Tree
{
    //Need to be public to be accessed elsewhere
    public UnityEngine.Transform waypoint;
    private static float speed = 0f;
    private static float attackRange = 3.5f;
    public static float FOVRange = 12f;
    private static int UnitDmg = 5;

    public TurretTree(float attackrange, float speed)
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
            }),/*
            new Sequence(new List<KevNode>
            {
                new CheckFOVRange(transform),
                new GoToTarget(transform),
            }),*/
            new Walk(transform, waypoint, speed),
        });

        return root;
    }
}
