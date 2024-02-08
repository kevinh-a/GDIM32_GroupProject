using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSummoningButton : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Units;

    public void LightSaber()
    {
        //Refer to the ENUMS in CharacterCardSO
        Instantiate(Units[0]);
    }
    public void LaserGunner()
    {
        //Refer to the ENUMS in CharacterCardSO
        Instantiate(Units[1]);
    }
    public void LightsaberSupreme()
    {
        //Refer to the ENUMS in CharacterCardSO
        Instantiate(Units[2]);
    }
}
