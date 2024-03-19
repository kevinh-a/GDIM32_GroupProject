using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGunner : CharacterBase
{
    public Animator animator;
    public float runSpeed = 2f;

    float horiztonalMove = 0f;
    //WILL BE MODIFIED SECOND PLAYTEST ALONG WITH OTHER UNIT TYPES
     //Currently this unit moves to the left. 
     void Update()
    {
        horiztonalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("DistanceFromTarget", Mathf.Abs(horiztonalMove));
        transform.position = new Vector3(transform.position.x + Speed, transform.position.y);
    }
    
}
