using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class NPCHandler : MonoBehaviour, IInteractable
{
    private Dialogue _dialogue;
    public event IInteractable.InteractionEvent OnInteract;
    public Dialogue GetDialogue()
    {
        return _dialogue;
    }

    public void Interact()
    {
        OnInteract.Invoke();
        if (_dialogue != null)
        {
            DialogueHandler.InvokeDialogue(GetDialogue());
            _dialogue = _dialogue.nextDialogue;
        } 
        else
        {
            DialogueHandler.InvokeDialogue(null);
        }
    }
    public void SetDialogue(Dialogue dialogue)
    {
        _dialogue = dialogue;
    }
}
