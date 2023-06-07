using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayer : MonoBehaviour
{

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        foreach(CardEffect1 cardEffect in card.cardEffects)
        {
            foreach(CardEffect cf in cardEffect.effects)
                cf.Evaluate(card);
        }
    }

}
