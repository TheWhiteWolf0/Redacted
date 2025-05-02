using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        enteredTrigger.Invoke();
        Debug.Log("Entered Trigger: ");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        exitedTrigger.Invoke();
    }
}