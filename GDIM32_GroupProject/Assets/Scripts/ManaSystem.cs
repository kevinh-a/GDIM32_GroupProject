using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSystem : MonoBehaviour
{
    private int MaxManaCount;
    private int MinManaCount;



    // Start is called before the first frame update
    void Start()
    {
        MaxManaCount = 10;
        MinManaCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        while (MaxManaCount <=10)
        {
            MaxManaCount += 1;
        }
    }
}


