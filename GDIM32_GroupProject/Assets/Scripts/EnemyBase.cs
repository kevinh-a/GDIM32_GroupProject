using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    public static int health;
    [SerializeField]
    private int objectHp;
    /* For future tower damage reference (think of the boss/towers as an AI)
    [SerializeField]
    public int dmg;
    
    public int DealDmg()
    {
        //Useless for now
        return (dmg);
    }
    */
    void Start()
    {
        health = objectHp;
    }
    public static void TakeDmg(int dmg)
    {
        Debug.Log(health);
        health -= dmg;
        if(health <= 0)
        {
            Debug.Log("Destroyed");
            //Implement a winscreen here
        }
    }
}