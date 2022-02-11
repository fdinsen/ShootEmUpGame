using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeAbilityAction : AbilityAction
{
    [SerializeField] private float slowdownFactor = 0.1f;
    [SerializeField] private float slowdownLength = 2f;

    private float _defaultDeltaTime;

    public override void PerformAbility()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        StartCoroutine(SlowTime());
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Rework this to run as a Coroutine, to avoid it being run while ability is not in use
        /*Time.timeScale += (1.0f / slowdownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        if (Time.timeScale == 1.0f)
        {
            Time.fixedDeltaTime = _defaultDeltaTime;
        }*/
    }

    private void Start()
    {
        _defaultDeltaTime = Time.fixedDeltaTime;
    }

    IEnumerator SlowTime()
    {
        while (Time.timeScale < 1.0f)
        {
            Time.timeScale += (1.0f / slowdownLength) * 0.1f;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
            yield return new WaitForSeconds(0.1f);
        }

        Time.fixedDeltaTime = _defaultDeltaTime;
    }
}
