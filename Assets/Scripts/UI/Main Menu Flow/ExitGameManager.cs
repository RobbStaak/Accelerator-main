using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitGameManager : MonoBehaviour
{
    public void ApplicationQuit()
    {
        Application.Quit();
    }

    public void ExitFromEditor()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}


