using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueHandler : MonoBehaviour
{
    [SerializeField] GameObject _dialogueBox;
    [SerializeField] TMP_Text _text;

    public delegate void DialogueEvent(string dialogue);
    public static event DialogueEvent DoDialogue;

    private PlayerMovement _movement;

    // Start is called before the first frame update
    void Awake()
    {
        _movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        _dialogueBox.SetActive(false);
        DoDialogue += HandleDialogue;
    }

    void HandleDialogue(string dialogue)
    {
        _dialogueBox.SetActive(dialogue != null);
        _text.text = dialogue;
        _movement.TogglePlayerMovement(dialogue == null);
    }

    public static void InvokeDialogue(string dialogue)
    {
        DoDialogue.Invoke(dialogue);
    }
}
