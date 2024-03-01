using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jasmine Chen
public class DamageSpell : BaseSpell
{
    [SerializeField] protected Rigidbody2D rb;

    private GameObject NewSpell;

    

    public override void DoSpell()
    {
        Debug.Log("Spawning...?");
        Instantiate(NewSpell);

    }

}

