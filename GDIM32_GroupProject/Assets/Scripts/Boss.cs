using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen

public class Boss : MonoBehaviour
{
    [SerializeField] public float maxHealth;
    [SerializeField] public float setDamage;
    [SerializeField] protected float Currenthealth;
    protected float dmg;


    // Start is called before the first frame update
    void Start()
    {
        Currenthealth = maxHealth;
        dmg = setDamage;
    }

    // Update is called once per frame
    void Update()
    {
         if (Currenthealth <= 0)
        {   
            die();
        }
    }

    public bool DamageEnemy(float dmg)
    {
       
        if (Currenthealth < dmg)
        {
            Currenthealth = 0;
            return true;
        }
        else
        {
            Currenthealth -= dmg;
            return false;
        }
    }
    
    public void die()
    {
        Destroy(gameObject);
    }
}