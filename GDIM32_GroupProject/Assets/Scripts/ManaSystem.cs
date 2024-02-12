using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Jasmine Chen

public class ManaSystem : MonoBehaviour
{

    private float MaxManaCount;
    private float MinManaCount;
    [SerializeField]
    public float CurrentMana;
    public Slider slider;


    public void SetMana(float CurrentMana)
    {
        slider.maxValue = CurrentMana;
        slider.value = CurrentMana;
    }


    public void ManaRegen()
    {
        while (CurrentMana <= MaxManaCount)
        {
            CurrentMana += .1f;
        }
    }
}

