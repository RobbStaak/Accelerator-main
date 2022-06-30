using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class LoadGame : MonoBehaviour
{


    [Header("LOAD GAME")]
    [TextArea(minLines: 1, maxLines: 2)]
    public string _LoadGameName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadGameName()
    {
        SceneManager.LoadScene(_LoadGameName);
    }

}
