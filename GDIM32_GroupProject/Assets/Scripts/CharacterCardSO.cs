using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "CardGame/UnitCards")]
public class CharacterCardSO : ScriptableObject
{
    public enum unitType
    {
        LIGHTSABER,
        LASERGUNNER,
        ELEMCASTER,
        GOONS,
        LIGHTSABERSUPREME,
        TURRET
    }

    [SerializeField]
    private GameObject[] UnitInCard;
    [SerializeField]
    private string CardName;
    [SerializeField]
    public int BaseHp { get; private set; }
    [SerializeField]
    private int ManaCost;
    [SerializeField]
    private Sprite CardIcon;
    [SerializeField]
    private float Speed;
    [SerializeField]
    private int Dmg;
    //For units that spawn more than one instance of itself
    [SerializeField]
    private int amountSpawned;

    public string GetName()
    {
        return CardName;
    }
    public Sprite GetIcon()
    {
        return CardIcon;
    }
    public int GetCost()
    {
        return ManaCost;
    }
}
