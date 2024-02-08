using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    //public float Speed { get; private set; }
    //public int BaseHp { get; private set; }

    [SerializeField]
    private CharacterCardSO CharacterDetails;

    void Update()
    {
        
    }

    private void DealDmg()
    {
        //CharacterDetails.BaseHp = 0;
    }

    private void TakeDmg()
    {
        //BaseHp == 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "damageable")
        {
            DealDmg();
            TakeDmg();
        }

    }

}
