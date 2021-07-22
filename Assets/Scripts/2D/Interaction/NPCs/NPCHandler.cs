using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class NPCHandler : MonoBehaviour, IInteractable
{
    [SerializeField] private Dialogue _dialogue;

    public Dialogue GetDialogue()
    {
        return _dialogue;
    }

    public void Interact()
    {
        if (_dialogue != null)
        {
            DialogueHandler.InvokeDialogue(GetDialogue().content);
            _dialogue = _dialogue.nextDialogue;
        } 
        else
        {
            DialogueHandler.InvokeDialogue(null);
        }
    }
}
