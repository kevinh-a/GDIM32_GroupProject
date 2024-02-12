using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    public int health;
    [SerializeField]
    private int objectHp;
    [SerializeField]
    private int dmg;
    
    public int DealDmg()
    {
        //Useless for now
        return (dmg);
    }
    void Start()
    {
        health = objectHp;
    }
    public void TakeDmg(int dmg)
    {
        Debug.Log(health);
        health -= dmg;
        if(health <= 0)
        {
            Debug.Log("Destroyed");
            //SceneManager.LoadScene(2);
        }
    }
}
