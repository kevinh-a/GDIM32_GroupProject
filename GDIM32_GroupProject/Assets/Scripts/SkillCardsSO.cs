using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen

[CreateAssetMenu(menuName = "CardGame/SkillCards")]
public class SOSkillCards : ScriptableObject
{
    public enum CardType
    {
        SPEEDUP,
        HEAL,
        AOE,
        STUN,
        DAMAGEUP
    }

    [SerializeField]
    private string displayName;
    [SerializeField]
    private Sprite displayIcon;
    [SerializeField]
    private int ManaCost;
    // [SerializeField]
    //private CreateInstance prefab;
    [SerializeField]
    private int damage; 


    public string GetName()
    {
        return displayName;
    }

    public int GetCost()
    {
        return ManaCost;
    }

    public Sprite GetIcon()
    {
        return displayIcon;
    }

    public int GetDamage()
    {
        return damage;
    }

}
