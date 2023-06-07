using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardEffect1 : ScriptableObject
{
    [SerializeReference] public List<CardEffect> effects = new List<CardEffect>();
    [ContextMenu("Add Light Attack Effect")]
    public void AddLightAttackEffect()
    {
        effects.Add(new LightAttackCardEffect());
    }

    [ContextMenu("Add Heavy Attack Effect")]
    public void AddHeavyAttackEffect()
    {
        effects.Add(new HeavyAttackCardEffect());
    }
}
