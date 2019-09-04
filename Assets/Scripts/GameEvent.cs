using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)] // 1
public class GameEvent : ScriptableObject // 2
{
    private List<GameAction> listeners = new List<GameAction>(); // 3

    public void Raise() // 4
    {
        for (int i = listeners.Count - 1; i >= 0; i--) // 5
        {
            listeners[i].OnEventRaised(); // 6
        }
    }

    public void RegisterListener(GameAction listener) // 7
    {
        listeners.Add(listener);
    }

    public void UnRegisterListener(GameAction listener) // 8
    {
        listeners.Remove(listener);
    }
}