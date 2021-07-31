using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneSwitchAction : AbilityAction
{
    [SerializeField] private string _targetScene;

    public override void PerformAbility()
    {
        SceneHandler.Instance.LoadScene(_targetScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
