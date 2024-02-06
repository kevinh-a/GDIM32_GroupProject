using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private int cost;
    [SerializeField]
    private SkillInstance prefab;


    public string GetName()
    {
        return displayName;
    }

    public int GetCost()
    {
        return cost;
    }

    public Sprite GetIcon()
    {
        return displayIcon;
    }
}
