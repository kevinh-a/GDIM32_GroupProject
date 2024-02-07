using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField]
    private PlayerStats playerInfo;
    [SerializeField]
    private CardStats cardInfo;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Text cardName;
    [SerializeField]
    private Text cost;

    public PlayerStats PlayerInfo
    {
        get { return playerInfo; }
        set { playerInfo = value; }
    }
    public CardStats CardInfo
    {
        get { return cardInfo; }
        set { cardInfo = value; }
    }
    public Image Icon
    {
        get { return icon; }
    }
    public Text CardName
    {
        get { return cardName; }
    }
    public Text Cost
    {
        get { return cost; }
    }

    private void Update()
    {
        icon.sprite = cardInfo.Icon;
        cardName.text = cardInfo.Name;
        cost.text = cardInfo.Cost.ToString();
    }
}
