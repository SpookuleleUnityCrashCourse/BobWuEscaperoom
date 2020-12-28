using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidBox : MonoBehaviour, IInteractable
{
    public GameObject floor;

    public void OnInteract()
    {
        Destroy(floor);
    }

    public string GetPrompt()
    {
        return "click to see the void";
    }
}
