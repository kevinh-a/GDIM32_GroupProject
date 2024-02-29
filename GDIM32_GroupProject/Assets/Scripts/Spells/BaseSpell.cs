using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
    {
        SPEEDUP,
        HEAL,
        AOE,
        STUN,
        DAMAGEUP
    }

public class BaseSpell : MonoBehaviour
{
    [SerializeField] protected string Name;
    [SerializeField] protected float ManaCost;
    [SerializeField] protected float DamageCount;

}
