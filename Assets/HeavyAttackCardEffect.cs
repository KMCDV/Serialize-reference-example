using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttackCardEffect : CardEffect
{
    public HeavyAttackCardEffect()
    {
        Description = "Heavy attack";
    }

    public override void Evaluate(Card sender)
    {
        Debug.Log("HEAVY: " + sender.damage * 2);
    }
}
