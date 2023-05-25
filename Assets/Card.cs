using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public string cardName;
    public int damage;
    public InfantryType infantryType;
    [SerializeReference] public List<CardEffect> cardEffects = new List<CardEffect>();

    [ContextMenu("Add Light Attack Effect")]
    public void AddLightAttackEffect()
    {
        cardEffects.Add(new LightAttackCardEffect());
    }

    [ContextMenu("Add Heavy Attack Effect")]
    public void AddHeavyAttackEffect()
    {
        cardEffects.Add(new HeavyAttackCardEffect());


        if(infantryType.HasFlag(InfantryType.A_TEAM))
        {

        }
    }


}

[Flags]
public enum InfantryType
{
    Light = 1,
    Heavy = 2,
    Trooper = 4,
    Whatever = 8,
    A_TEAM = Light | Heavy | Trooper,   
}
