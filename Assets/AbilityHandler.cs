using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    private PlayerShipAbilityHandler _shipAbilityHandler;

    private Ability abilitySlot1;
    private Ability abilitySlot2;
    private Ability abilitySlot3;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _shipAbilityHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShipAbilityHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
