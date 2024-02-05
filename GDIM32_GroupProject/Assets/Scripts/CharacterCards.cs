using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CharacterCards
{

    CharacterCards handOfCards { get; set; }

    int GetCard();

    void AddToHand(List<CharacterCards> toAdd);

    void PlaceHand(List<CharacterCards> toPlace);

    void Discard(List<CharacterCards> DiscardCard);
}
