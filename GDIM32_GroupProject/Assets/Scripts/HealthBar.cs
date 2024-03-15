using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	[SerializeField]
    private float MaxHealthCount;
    [SerializeField]
    private float CurrentHealth;
    public Slider slider;

    public float GetHealth()
    {
        return CurrentHealth;
    }

    public void SetHealth(float CurrentHealth)
    {
        slider.maxValue = MaxHealthCount;
        slider.value = CurrentHealth;
    }

    public void DepleteHealth(float DamageHit)
    {
        CurrentHealth -= DamageHit;
        slider.value = CurrentHealth;
    }


      private void Update()
    {
        slider.value = CurrentHealth;
    }


}