using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterInstance : MonoBehaviour, CharacterCards
{
    private int currentCharCard;

    public string DisplayName { get; private set; }
    public int ManaCost { get; private set; }
    public float CharSpeed { get; private set; }
    public int BaseDmg { get; private set; }

    public CharacterCards handOfCards { get; set; }

    public void Initialize(string name, int manaCost, float speed, int dmg)
    {
        DisplayName = name;
        ManaCost = manaCost;
        CharSpeed = speed;
        BaseDmg = dmg;
    }

    public int GetCard()
    {
        return currentCharCard;
    }

    public void AddToHand(List<CharacterCards> toAdd)
    {

    }

    public void PlaceHand(List<CharacterCards> toPlace)
    {

    }

    public void Discard(List<CharacterCards> DiscardCard)
    {
        Destroy(gameObject);
    }
}
