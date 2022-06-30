using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExitGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false; // if you want to close in unity editor
        Application.Quit(); // Can close when build and run application
    }



}
