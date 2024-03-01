using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class MeleeSaber : BehaviorTree.Tree
{
    public UnityEngine.Transform waypoint;
    public static float speed = 2f;
    protected override KevNode SetupTree()
    {
        KevNode root = new Walk(transform, waypoint);
        /*
        KevNode root = new Selector(new List<KevNode>
        {
            new Sequence(new List<KevNode>
            {
                new CheckForTargets(transform),
                new TaskAttack(transform),
            }),
            new Sequence(new List<KevNode>
            {
                new CheckForTargets(transform),
                new GoToTarget(transform),
            }),
            new Walk(transform, waypoint),
        });*/

        return root;
    }
}
