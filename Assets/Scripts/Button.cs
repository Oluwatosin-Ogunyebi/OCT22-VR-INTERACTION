using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent onButtonPressed;
    public UnityEvent onButtonReleased;

    public Transform buttonPos, buttonUpPos, buttonDownPos;

    public void ButtonPressed()
    {
        buttonPos.position = buttonDownPos.position;
        onButtonPressed.Invoke();
    }

    public void ButtonReleased()
    {
        buttonPos.position = buttonUpPos.position;
        onButtonReleased.Invoke();
    }
}
