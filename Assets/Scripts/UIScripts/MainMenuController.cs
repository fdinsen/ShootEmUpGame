using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    [SerializeField] private string targetScene;

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("StartButton");
        exitButton = root.Q<VisualElement>("Horizontal").Q<Button>("ExitGame");

        startButton.clicked += StartButtonPressed;
        exitButton.clicked += ExitButtonPressed;
        print(exitButton);
    }

    void StartButtonPressed()
    {
        gameObject.SetActive(false);
        SceneHandler.Instance.LoadScene(targetScene);
    }

    void ExitButtonPressed()
    {
        Debug.Log("EXit");
        Application.Quit();
    }
}
