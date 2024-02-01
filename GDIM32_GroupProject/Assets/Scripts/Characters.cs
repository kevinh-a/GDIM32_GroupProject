using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    protected float speed;
    // For now, damage will be instant and collideable
    protected int damage;

    abstract public void Move{
    }
}
