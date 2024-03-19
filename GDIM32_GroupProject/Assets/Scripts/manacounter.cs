using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Jasmine Chen

public class Manacount : MonoBehaviour
{

    [SerializeField]
    public ManaSystem Mana;
    public Text ValueText;
    private int GetValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("is the mana counting??");
        //GetValue = (int)Mana.GetMana();
       // ValueText.text = "Mana: " + GetValue.ToString();
    }
}
