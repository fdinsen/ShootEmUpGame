using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChangeSceneTestAbility", menuName = "ScriptableObjects/Ability/ChangeSceneTestAbility", order = 1)]
public class ChangeSceneTestAbility : Ability
{
    public string _targetScene;

    public override void PerformAbility()
    {
        SceneHandler.Instance.LoadScene(_targetScene);
    }
}
