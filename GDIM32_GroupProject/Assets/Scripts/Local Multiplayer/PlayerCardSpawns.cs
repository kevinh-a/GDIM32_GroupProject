using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen
public class PlayerCardSpawns : MonoBehaviour
{
    [SerializeField] private GameObject[] Units;
    [SerializeField] private GameObject[] SpawnPoints;
    [SerializeField] public ManaSystem Mana;

    [Header("Cards")]
    [SerializeField] private KeyCode one;
    [SerializeField] private KeyCode two;
    [SerializeField] private KeyCode three;

    private float CooldownTime = 1;
    private float NextUseTime = 0;

 
    private int Player1Location()
    {
        return Random.Range(0, SpawnPoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(one) && Time.time > NextUseTime)
        {
            CardOne();
        }
        else if (Input.GetKey(two) && Time.time > NextUseTime)
        {
            CardTwo();
        }
        else if (Input.GetKey(three) && Time.time > NextUseTime)
        {
            CardThree();
        }
        
    }

    public void CardOne()
    {
        if (Mana.GetMana() >= 3)
        {
            //Debug.Log("ONE!");

            Instantiate(Units[0], SpawnPoints[Player1Location()].transform);
            Mana.DepleteMana(3);
            //Debug.Log("Cooling Down");
            NextUseTime = Time.time + CooldownTime;

        }
    }

    public void CardTwo()
    {
        if (Mana.GetMana() >= 4)
        {
            Instantiate(Units[1], SpawnPoints[Player1Location()].transform);
            Mana.DepleteMana(4);
            NextUseTime = Time.time + CooldownTime;

        }
    }

    public void CardThree()
    {
        if (Mana.GetMana() >= 6)
        {
            Instantiate(Units[2], SpawnPoints[Player1Location()].transform);
            Mana.DepleteMana(6);
            NextUseTime = Time.time + CooldownTime;

        }
    }


}
