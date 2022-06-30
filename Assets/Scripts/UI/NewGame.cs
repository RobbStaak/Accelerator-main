using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{


    [Header("NEW GAME")]
    [TextArea(minLines: 1, maxLines: 2)]
    public string _NewGameName;


   

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void NewGameName()
    {
        SceneManager.LoadScene(_NewGameName);
    }
}
