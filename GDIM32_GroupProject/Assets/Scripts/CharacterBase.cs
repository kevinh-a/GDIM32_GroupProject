using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField]
    protected float Speed;
    [SerializeField]
    protected int BaseHp;
    [SerializeField]
    protected int dmg;
    [SerializeField]
    private CharacterCardSO CharacterDetails;
    [SerializeField]
    private Rigidbody2D rb;
    //private EnemyBase collidedObject;

    //This will be in the base class until there is a more advanced AI on every unit (second playtest material)
    void Update()
    {
        //First one is way too fast
        //transform.position = new Vector3(transform.position.x + Speed, transform.position.y);
        rb.velocity = new Vector2(Speed, 0f);
    }

    private int DealDmg()
    {
        return dmg;
    }

    private void TakeDmg(int dmg)
    {
        BaseHp = dmg;
        if(BaseHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyBase")
        {
            //collidedObject = collision.gameObject.EnemyBase;
            Destroy(gameObject);
            TakeDmg(dmg);
            //collidedObject.TakeDmg(BaseHp);
        }

    }

}
