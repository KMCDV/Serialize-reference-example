using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttackCardEffect : CardEffect
{

    public float modificator;
    public bool shouldAttackTwice;
    public LightAttackCardEffect()
    {
        Description = "Light Effect";
    }

    public override void Evaluate(Card sender)
    {
        Debug.Log("LIGHT: " + sender.damage * .1f * modificator);



    }
}
