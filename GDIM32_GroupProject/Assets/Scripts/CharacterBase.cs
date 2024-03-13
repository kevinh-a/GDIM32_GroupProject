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
    public Rigidbody rb;
    [SerializeField]
    public float AttackRange;
    void Start()
    {
        BaseHp = MaxHp;
    }

    private int DealDmg()
    {
        return dmg;
    }

    public void TakeDmg(int dmg)
    {
        BaseHp -= dmg;
        if(BaseHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Boss>(out Boss enemyProperties))
        {
            enemyProperties.DamageEnemy(DealDmg());
            TakeDmg((int)enemyProperties.setDamage);
        }

        if(collision.gameObject.TryGetComponent<EnemyMinion>(out EnemyMinion MinionProperties))
        {
            MinionProperties.DamageEnemy(DealDmg());
            TakeDmg((int)MinionProperties.setDamage);
        }
    }*/

    public float GetSpeed()
    {
        return Speed;
    }

    //public abstract void Movement()
}
