using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipAbilityHandler : MonoBehaviour
{
    //[SerializeField] private ActiveAbilities _activeAbilities;

    private float[] _abilityActionCooldowns = {0f,0f,0f};
    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CombatMovement.Enable();
        _playerInput._2DMovement.Disable();
        _playerInput.CombatMovement.AbilitySlot1.performed += ctx => UseAbility(PlayerActiveAbilities.AbilitySlot1, 0);
        _playerInput.CombatMovement.AbilitySlot2.performed += ctx => UseAbility(PlayerActiveAbilities.AbilitySlot2, 1);
        _playerInput.CombatMovement.AbilitySlot3.performed += ctx => UseAbility(PlayerActiveAbilities.AbilitySlot3, 2);
    }
    void OnDisable()
    {
        _playerInput.CombatMovement.Disable();
    }
    
    void UseAbility(Ability action, int cooldownIndex)
    {
        if(_abilityActionCooldowns[cooldownIndex] <= 0f)
        {
            action.PerformAbility();
            _abilityActionCooldowns[cooldownIndex] = action.cooldown;
        }
    }

    void Update()
    {
        CountDownCooldownList(_abilityActionCooldowns);
        Debug.Log(PlayerActiveAbilities.AbilitySlot1.name);
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
