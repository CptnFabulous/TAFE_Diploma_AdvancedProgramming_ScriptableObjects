using UnityEngine;

[ExecuteInEditMode] // 1
public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameAction[] actions; // 2

    private void Update() // 3
    {
        if (Application.isEditor)
        {
            foreach (var action in actions)
            {
                action.Update();
            }
        }
    }

    private void OnEnable() // 4
    {
        foreach (var action in actions)
        {
            action.RegisterListener();
        }
    }

    private void OnDisable() // 5
    {
        foreach (var action in actions)
        {
            action.UnRegisterListener();
        }
    }
}