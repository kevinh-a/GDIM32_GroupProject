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
    private ManaSystem Mana;

    public void LightSaber()
    {
        if (Mana.CurrentMana >= 3)
        {
            //Refer to the ENUMS in CharacterCardSO
            Instantiate(Units[0]);
            Mana.CurrentMana -= 3;
        }
    }
    public void LaserGunner()
    {
        if (Mana.CurrentMana >= 4)
        {
            //Refer to the ENUMS in CharacterCardSO
            Instantiate(Units[1]);
            Mana.CurrentMana -= 4;
        }
    }
    public void LightsaberSupreme()
    {
        if (Mana.CurrentMana >= 6)
        {
            //Refer to the ENUMS in CharacterCardSO
            Instantiate(Units[2]);
            Mana.CurrentMana -= 6;
        }
    }
}
