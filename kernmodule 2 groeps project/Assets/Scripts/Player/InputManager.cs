using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    private GameManager gameManager;
    public Dictionary<KeyCode, EventType> keybindings = new Dictionary<KeyCode, EventType>();

    public InputManager(GameManager _gameManager)
    {
        gameManager = _gameManager;

        // set up some basic keybinds
        keybindings.Add(KeyCode.A,              EventType.INPUT_LEFT);
        keybindings.Add(KeyCode.D,              EventType.INPUT_RIGHT);
        keybindings.Add(KeyCode.W,              EventType.INPUT_FORWARD);
        keybindings.Add(KeyCode.S,              EventType.INPUT_BACK);
        keybindings.Add(KeyCode.E,              EventType.INPUT_NEXT_WEP);
        keybindings.Add(KeyCode.Q,              EventType.INPUT_PREV_WEP);
        keybindings.Add(KeyCode.Space,          EventType.INPUT_UP);
        keybindings.Add(KeyCode.LeftControl,    EventType.INPUT_DOWN);
    }

    // check if any key is pressed and fire event related to it
    public void CheckInput()
    {
        foreach (KeyValuePair<KeyCode, EventType> keybinding in keybindings)
        {
            if (Input.GetKey(keybinding.Key))
            {
                EventSystem.InvokeEvent(keybinding.Value);
            }
        }
    }
}