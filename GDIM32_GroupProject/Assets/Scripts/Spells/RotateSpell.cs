using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpell : BaseSpell
{
    private GameObject NewSpell;
    [SerializeField] private Transform rotateAround;
    [SerializeField] protected Rigidbody2D rb;
    private float RotationSpeed = 45f;
    private float uptime = 0;

    public override void DoSpell()
    {
        //Debug.Log("Spawning...?");
        Instantiate(NewSpell);

    }

    void Update()
    {
        this.transform.RotateAround(rotateAround.position, Vector3.forward, RotationSpeed * Time.deltaTime );

        uptime += Time.deltaTime;
        //Debug.Log(uptime);

        if(uptime >= 5)
        {
            Debug.Log("nothing hit...?");
            Destroy(gameObject);
            uptime = 0;
        }
    }
}

