using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(NPCHandler))]
public abstract class Character : MonoBehaviour
{
    //// Protected fields ////
    [SerializeField] protected Dialogue[] dialogueForEachLevel;
    protected readonly int MAX_LEVEL = 10;
    protected NPCHandler handler;

    //// Public fields ////
    public delegate void FriendshipLevelUp(Character character);
    public event FriendshipLevelUp OnLevelUp;

    //// Abstract fields ////
    abstract public string CharacterName { get; }
    /// <summary>Use instead of Start(). Is called on Start.</summary>
    protected abstract void OnStarting();
    /// <summary>Use instead of Update(). Is called on Update.</summary>
    protected abstract void OnUpdate();

    //// Public methods ////
    public void AddFriendshipPoints(int points)
    {
        CharactersInfo.IncreaseFriendshipPoints(CharacterName, points);
        if (CharactersInfo.GetFriendshipPoints(CharacterName) >= 100)
        {
            LevelUp();
        }
    }

    //// Private methods ////
    private void SetDialogue() //Called when player interacts with a character
    {
        try
        {
            handler.SetDialogue(dialogueForEachLevel[CharactersInfo.GetFriendshipLevel(CharacterName)]);
        }
        catch (IndexOutOfRangeException)
        {
            //If there is no dialogue set for the current level, just use the highest level one. 
            // This should only happen during development
            handler.SetDialogue(dialogueForEachLevel[dialogueForEachLevel.Length - 1]);
        }
    }
    private void LevelUp()
    {
        if (CharactersInfo.GetFriendshipLevel(CharacterName) < MAX_LEVEL)
        {
            CharactersInfo.DecreaseFriendshipPoints(CharacterName, 100);
            CharactersInfo.IncreaseFriendshipLevel(CharacterName, 1);
            OnLevelUp.Invoke(this);
        }
    }

    //// MonoBehaviour ////
    // Start is called before the first frame update
    void Start()
    {
        handler = GetComponent<NPCHandler>();
        handler.OnInteract += SetDialogue;

        Debug.Log("Remember to remove line adding character to PlayerSetup from Character.cs -> Start()");
        CharactersInfo.AddCharacter(CharacterName);
        OnLevelUp += t => Debug.Log("Level Up!"); // The only point of this line is to stop OnLevelUp from throwing an error when nothing is subscribed to it. 

        OnStarting();
    }

    // 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)) AddFriendshipPoints(50);
        OnUpdate();
    }

}
