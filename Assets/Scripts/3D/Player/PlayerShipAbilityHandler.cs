using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipAbilityHandler : MonoBehaviour
{
    [SerializeField] private AbilityAction _abilityActionSlot1;
    [SerializeField] private AbilityAction _abilityActionSlot2;
    [SerializeField] private AbilityAction _abilityActionSlot3;

    private float[] _abilityActionCooldowns = {0f,0f,0f};
    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
        _playerInput.CombatMovement.AbilitySlot1.performed += ctx => UseAbility(_abilityActionSlot1, 0);
        _playerInput.CombatMovement.AbilitySlot2.performed += ctx => UseAbility(_abilityActionSlot2, 1);
        _playerInput.CombatMovement.AbilitySlot3.performed += ctx => UseAbility(_abilityActionSlot3, 2);
    }
    
    void UseAbility(AbilityAction action, int cooldownIndex)
    {
        if(_abilityActionCooldowns[cooldownIndex] <= 0f)
        {
            action.PerformAbility();
            _abilityActionCooldowns[cooldownIndex] = _abilityActionSlot1.GetAbilityCooldown();
        }
    }

    void Update()
    {
        CountDownCooldownList(_abilityActionCooldowns);
    }

    void CountDownCooldownList(float[] listOfCooldowns)
    {
        for (int i = 0; i < listOfCooldowns.Length; i++)
        {
            if (listOfCooldowns[i] > 0f)
            {
                listOfCooldowns[i] -= Time.deltaTime;
            }
        }
    }
}
