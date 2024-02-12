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
        StartCoroutine(RegenMana());
    }

    // Update is called once per frame
    private IEnumerator RegenMana()
    {
        while (CurrentMana <= MaxManaCount)
        {
            CurrentMana += .2f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}


