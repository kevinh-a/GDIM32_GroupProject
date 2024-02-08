using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : CharacterBase
{
    public int unitHp;
    public float unitSpeed;
    public int unitDmg;
    public int unitCost;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize("Lightsaber", unitCost, unitSpeed, unitDmg, unitHp);
    }

    // Currently this unit moves to the left.
    void Update()
    {
        transform.position = new Vector3(transform.position.x + unitSpeed, transform.position.y);
    }
}
