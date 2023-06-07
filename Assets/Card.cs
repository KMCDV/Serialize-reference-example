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


    public Action<TurnTiming> turnTiming;


    void foo()
    {
        turnTiming?.Invoke(TurnTiming.PlayerTurnStart);
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

[Flags]
public enum TurnTiming
{
    PlayerTurnStart = 1,
    PlayerTurnEnd = 2,
    PlayerTurnCancel = 4,
    CardActionEnd = 8,
    CardActionStart = 16
}
