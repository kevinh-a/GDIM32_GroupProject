using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpell : BaseSpell
{
    private GameObject NewSpell;
    //public GameObject wayPoint;
    //private float timer = 0.5f;
    [SerializeField] private Transform rotateAround;
    [SerializeField] protected Rigidbody2D rb;
    private float RotationSpeed = 100f;
    private float uptime = 0;

    public override void DoSpell()
    {
        //Debug.Log("Spawning...?");
        Instantiate(NewSpell);

    }

    void Update()
    {
        this.transform.RotateAround(rotateAround.position, Vector3.forward, RotationSpeed * Time.deltaTime);

        uptime += Time.deltaTime;
        //Debug.Log(uptime);

        if(uptime >= 10)
        {
            Debug.Log("nothing hit...?");
            Destroy(gameObject);
            uptime = 0;
        }

        /*if(timer > 0)
        {
          timer -= Time.deltaTime;
        }
         if(timer <= 0)
        {
          //The position of the waypoint will update to the player's position
          UpdatePosition();
          timer = 0.5f;
        }

    void UpdatePosition()
    {
     wayPoint.transform.position = transform.position;
    }
    */
    }
    
}

