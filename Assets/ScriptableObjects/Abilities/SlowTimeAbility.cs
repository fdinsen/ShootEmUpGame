using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SlowTimeAbility", menuName = "ScriptableObjects/Ability/SlowTimeAbility", order = 1)]
public class SlowTimeAbility : Ability
{
    public float slowdownFactor = 0.1f;
    public float slowdownLength = 2f;


    private float _defaultDeltaTime;
    private float _loopTime = 0.1f;
    private GameObject CoWorker;
    private ExecuteCoroutine executor;

    public override void PerformAbility()
    {
        if(CoWorker == null)
        {
            CoWorker = new GameObject();
            executor = CoWorker.AddComponent<ExecuteCoroutine>();
        }

        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        executor.StartCoroutine(SlowTime());
    }

    private void OnEnable()
    {
        _defaultDeltaTime = Time.fixedDeltaTime;
    }

    IEnumerator SlowTime()
    {
        while(Time.timeScale < 1.0f)
        {
            Time.timeScale += (1.0f / slowdownLength) * _loopTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
            yield return new WaitForSeconds(_loopTime);
        }

        Time.fixedDeltaTime = _defaultDeltaTime;
    }
}

public class ExecuteCoroutine : MonoBehaviour
{
    public static ExecuteCoroutine instance;

    private void Awake()
    {
        ExecuteCoroutine.instance = this;
    }
}
