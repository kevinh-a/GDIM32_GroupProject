using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMinion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float maxHealth;
    [SerializeField] public float setDamage;
    [SerializeField] protected float Currenthealth;
    protected float dmg;
    private float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        Currenthealth = maxHealth;
        dmg = setDamage;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        this.transform.position = new Vector3(3, y, 0);
        
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
