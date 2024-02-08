using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "CardGame/UnitCards")]
public class CharacterCardSO : ScriptableObject
{
    //Will be used to hold card data for each unit available as a card
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
    private int ManaCost;
    [SerializeField]
    private Sprite CardIcon;
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
