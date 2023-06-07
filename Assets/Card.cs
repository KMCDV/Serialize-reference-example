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
    public List<CardEffect1> cardEffects = new List<CardEffect1>();

   


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
