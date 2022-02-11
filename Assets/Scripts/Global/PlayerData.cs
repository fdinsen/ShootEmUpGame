using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData 
{
    
}

public static class PlayerActiveAbilities
{
    public static Ability AbilitySlot1 { get; set; }
    public static Ability AbilitySlot2 { get; set; }
    public static Ability AbilitySlot3 { get; set; }
}

public static class CharactersInfo
{
    private static Dictionary<string, int> _friendshipLevels = new Dictionary<string, int>();
    private static Dictionary<string, int> _friendshipPoints = new Dictionary<string, int>();

    public static int GetFriendshipLevel(string name)
    {
        _friendshipLevels.TryGetValue(name, out int f_level);
        return f_level;
    }
    public static int GetFriendshipPoints(string name)
    {
        _friendshipPoints.TryGetValue(name, out int f_points);
        return f_points;
    }

    public static void IncreaseFriendshipLevel(string name, int levels)
    {
        try { _friendshipLevels[name] += levels; }
        catch (KeyNotFoundException) { Debug.LogError($"Error! Attempted to increase friendship level, but no character by name {name} exists!"); }
    }

    public static void IncreaseFriendshipPoints(string name, int points)
    {
        try { _friendshipPoints[name] += points; }
        catch (KeyNotFoundException) { Debug.LogError($"Error! Attempted to increase friendship points, but no character by name {name} exists!"); }
    }
    public static void SetFriendshipLevel(string name, int levels)
    {
        try { _friendshipLevels[name] = levels; }
        catch (KeyNotFoundException) { Debug.LogError($"Error! Attempted to set friendship level, but no character by name {name} exists!"); }
    }

    public static void SetFriendshipPoints(string name, int points)
    {
        try { _friendshipPoints[name] = points; }
        catch (KeyNotFoundException) { Debug.LogError($"Error! Attempted to set friendship points, but no character by name {name} exists!"); }
    }
    public static void DecreaseFriendshipPoints(string name, int points)
    {
        try { _friendshipPoints[name] -= points; }
        catch (KeyNotFoundException) { Debug.LogError($"Error! Attempted to set friendship points, but no character by name {name} exists!"); }
    }

    public static void AddCharacter(string name)
    {
        _friendshipLevels.Add(name, 0);
        _friendshipPoints.Add(name, 0);
    }
}