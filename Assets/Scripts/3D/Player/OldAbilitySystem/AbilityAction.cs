using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerShipAbilityHandler))]
public abstract class AbilityAction : MonoBehaviour
{
    [SerializeField] protected Sprite _icon;
    [SerializeField] protected float _abilityCooldown;
    public abstract void PerformAbility();
    public float GetAbilityCooldown()
    {
        return _abilityCooldown;
    }

    public Sprite GetIcon()
    {
        return _icon;
    }
}
