using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipAbilityHandler : MonoBehaviour
{
    [SerializeField] private AbilityAction _abilityAction;

    private float _abilityActionCooldown = 0f;
    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
        _playerInput.CombatMovement.Ability.performed += ctx => UseAbility();
    }
    
    void UseAbility()
    {
        if(_abilityActionCooldown <= 0f)
        {
            _abilityAction.PerformAbility();
            _abilityActionCooldown = _abilityAction.GetAbilityCooldown();
        }
    }

    private void Update()
    {
        if(_abilityActionCooldown > 0f)
        {
            _abilityActionCooldown -= Time.deltaTime;
        }
    }
}
