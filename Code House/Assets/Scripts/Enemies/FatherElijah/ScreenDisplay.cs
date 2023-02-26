using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenDisplay : MonoBehaviour
{
    
    public TextMeshPro welcomeMessage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")) {
            welcomeMessage.text = "Clarence";
        }
    }
}
