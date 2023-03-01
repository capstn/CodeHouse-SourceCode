using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    
    public GameObject dialogue;

    private bool isActive;

    private void Start() 
    {
        isActive = false;
        dialogue.SetActive(isActive);
    }

    void Update() 
    {
        if (Input.GetKeyDown("escape")) 
        {
            isActive = !isActive;
            dialogue.SetActive(isActive);
        }
    }
}
