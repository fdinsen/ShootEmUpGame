using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour
{
    public static SceneHandler Instance;

    [SerializeField] private GameObject _loadingCanvas;
    [SerializeField] private Image _progressBar;

    private float _target;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(string sceneName)
    {
        _progressBar.fillAmount = 0;
        _target = 0;

        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;

        _loadingCanvas.SetActive(true);

        do
        {
            await Task.Delay(100); //TODO remove this line for build
            _target = scene.progress + 0.1f;
        } while (scene.progress < 0.9f);

        await Task.Delay(1000); //TODO remove this line for build
        scene.allowSceneActivation = true;
        _loadingCanvas.SetActive(false);
    }

    private void Update()
    {
        _progressBar.fillAmount = Mathf.MoveTowards(_progressBar.fillAmount, _target, 3 * Time.deltaTime);
    }
}
