using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen

public class ManaSystem : MonoBehaviour
{
    private int MaxManaCount;
    private int MinManaCount;
    [SerializeField]
    public float CurrentMana;


    // Start is called before the first frame update
    void Start()
    {
        MaxManaCount = 10;
        MinManaCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        while (CurrentMana <= MaxManaCount)
        {
            CurrentMana += .1f;
        }
    }
}


