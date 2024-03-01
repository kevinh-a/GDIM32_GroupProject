using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jasmine Chen
public abstract class BaseSpell : MonoBehaviour
{
    [SerializeField] protected string Name;
    [SerializeField] protected float ManaCost;
    [SerializeField] protected float DamageCount;
    private AudioSource audioplayer;

    void Start()
    {
        audioplayer = GetComponent<AudioSource>();
    }
    public virtual void DoSpell()
    {
     
    }

    private float DealDmg()
    {
        return DamageCount;
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Boss>(out Boss enemyProperties))
        {
            //Debug.Log("hurt...?");
            enemyProperties.DamageEnemy(DealDmg());
            audioplayer.Play();
            Destroy(gameObject);

        }
    }




}

