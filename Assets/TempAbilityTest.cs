using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempAbilityTest : MonoBehaviour
{
    public Ability ability1;
    public Ability ability2;
    public Ability ability3;
    public Ability AbilitySlot1 { get { return PlayerActiveAbilities.AbilitySlot1; } set { PlayerActiveAbilities.AbilitySlot1 = value; } }
    public Ability AbilitySlot2 { get { return PlayerActiveAbilities.AbilitySlot2; } set { PlayerActiveAbilities.AbilitySlot2 = value; } }
    public Ability AbilitySlot3 { get { return PlayerActiveAbilities.AbilitySlot3; } set { PlayerActiveAbilities.AbilitySlot3 = value; } }

    void Start()
    {
        AbilitySlot1 = ability1;
        AbilitySlot2 = ability2;
        AbilitySlot3 = ability3;
    }
}
