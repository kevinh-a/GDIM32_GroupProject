using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen

public class Boss : MonoBehaviour
{
    [SerializeField] public float maxHealth;
    [SerializeField] public float setDamage;
    protected float health;
    protected float dmg;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        dmg = setDamage;
    }

    // Update is called once per frame
    void Update()
    {
         if (health <= 0)
        {   
            die();
        }
    }

    public bool DamageEnemy(float dmg)
    {
       
        if (health < dmg)
        {
            health = 0;
            return true;
        }
        else
        {
            health -= dmg;
            return false;
        }
    }
    
    public void die()
    {
        Destroy(gameObject);
    }
}
