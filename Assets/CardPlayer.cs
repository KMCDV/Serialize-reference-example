using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayer : MonoBehaviour
{

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        foreach(CardEffect cardEffect in card.cardEffects)
        {
            cardEffect.Evaluate(card);
        }
    }

}
