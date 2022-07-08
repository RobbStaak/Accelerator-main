using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LoadGameSceneManager : MonoBehaviour
{
    [Header("LOAD GAME")]
    [TextArea(minLines: 1, maxLines: 2)]
    public string LoadGameName;

    private void Start()
    {

    }
    public void GameName()
    {
        SceneManager.LoadScene(LoadGameName);
    }
}
