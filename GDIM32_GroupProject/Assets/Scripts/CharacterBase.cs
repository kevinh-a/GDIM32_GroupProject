using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField]
    protected float Speed;
    [SerializeField]
    protected int MaxHp;
    [SerializeField]
    protected int BaseHp;
    [SerializeField]
    protected int dmg;
    [SerializeField]
    protected CharacterCardSO CharacterDetails;
    [SerializeField]
    public Rigidbody2D rb;
    [SerializeField]
    public float AttackRange;
    void Start()
    {
        BaseHp = MaxHp;
    }

    //This will be in the base class until there is a more advanced AI on every unit (second playtest material)
    void Update()
    {
        //First one is way too fast
        //transform.position = new Vector3(transform.position.x + Speed, transform.position.y);
        //rb.velocity = new Vector2(Speed, 0f);
    }

    private int DealDmg()
    {
        return dmg;
    }

    private void TakeDmg(int dmg)
    {
        BaseHp -= dmg;
        if(BaseHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Boss>(out Boss enemyProperties))
        {
            enemyProperties.DamageEnemy(DealDmg());
            TakeDmg((int)enemyProperties.setDamage);
        }
    }

    public float GetSpeed()
    {
        return Speed;
    }

    //public abstract void Movement()
}
