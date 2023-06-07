using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class CardEffect
{

   public string Description;
    public TurnTiming TurnTiming;
   
    public CardEffect()
    {
        Description = "Base Card Effect";
    }

   public virtual void Evaluate(Card sender)
    {

    }
}
