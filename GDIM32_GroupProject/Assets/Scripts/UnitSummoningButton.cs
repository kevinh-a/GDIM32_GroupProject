using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSummoningButton : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Units;
    [SerializeField]
    private GameObject[] SpawnPoints;
    [SerializeField]
    public ManaSystem Mana;


    private int randomIndex()
    {
        return Random.Range(0, SpawnPoints.Length);
    }

    public void LightSaber()
    {
        if (Mana.GetMana() >= 3)
        {
            //Refer to the ENUMS in CharacterCardSO

            Instantiate(Units[0], SpawnPoints[0].transform);
            Mana.DepleteMana(3);

        }
    }
    public void LaserGunner()
    {
        if (Mana.GetMana() >= 4)
        {
            //Refer to the ENUMS in CharacterCardSO

            Instantiate(Units[1]);
            Mana.DepleteMana(4);

        }
    }
    public void LightsaberSupreme()
    {
        if (Mana.GetMana() >= 6)
        {
            //Refer to the ENUMS in CharacterCardSO
            Instantiate(Units[2]);
            Mana.DepleteMana(6);
        }
    }

}
