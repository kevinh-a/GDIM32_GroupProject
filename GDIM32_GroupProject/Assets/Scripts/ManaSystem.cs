using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Jasmine Chen

public class ManaSystem : MonoBehaviour
{
    
    [SerializeField]
    private float MaxManaCount;
    [SerializeField]
    private float CurrentMana;
    public Slider slider;

    public float GetMana()
    {
        return CurrentMana;
    }

    public void SetMana(float CurrentMana)
    {
        slider.maxValue = MaxManaCount;
        slider.value = CurrentMana;
    }

    public void DepleteMana(float CardCost)
    {
        CurrentMana -= CardCost;
        slider.value = CurrentMana;
    }



    void Update()
    {
        Debug.Log(CurrentMana);
        Debug.Log(MaxManaCount);
        if (CurrentMana <= MaxManaCount)
        {
            Debug.Log("Inside if loop");
            CurrentMana += Time.deltaTime;
            slider.value = CurrentMana;
        }
    }
}
