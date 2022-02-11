using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string abilityName;
    public float cooldown;
    public Sprite icon;
    public abstract void PerformAbility();
}
