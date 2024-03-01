using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jasmine Chen
public class DamageSpell : BaseSpell
{
    private GameObject NewSpell;
    [SerializeField] protected Rigidbody2D rb;
    private float RotationSpeed = 10f;
    private float MoveSpeed = 3f;
    private float uptime = 0;


    public override void DoSpell()
    {
        
        //Debug.Log("Spawning...?");
        Instantiate(NewSpell);

    }

        void Update()
    {
        this.transform.Rotate ( Vector3.forward, RotationSpeed * Time.deltaTime );
        rb.velocity = transform.right * MoveSpeed;

        uptime += Time.deltaTime;
        //Debug.Log(uptime);

        if(uptime >= 2)
        {
            Debug.Log("nothing hit...?");
            Destroy(gameObject);
            uptime = 0;
        }
    }

}

