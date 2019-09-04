using UnityEngine;
using UnityEngine.Events; // 1

[System.Serializable]
public class GameAction
{
    [HideInInspector] public string name;
    public GameEvent gameEvent; // 2
    public UnityEvent gameAction; // 3

    public void Update()
    {
        if (gameEvent)
        {
            name = gameEvent.name;
        }
    }

    public void RegisterListener() // 4
    {
        gameEvent.RegisterListener(this);
    }

    public void UnRegisterListener() // 5
    {
        gameEvent.UnRegisterListener(this);
    }

    public void OnEventRaised() // 6
    {
        gameAction.Invoke();
    }
}