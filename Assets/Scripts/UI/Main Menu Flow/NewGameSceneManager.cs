using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGameSceneManager : MonoBehaviour
{
    [Header("NEW GAME")]
    [TextArea(minLines: 1, maxLines: 2)]
    public string NewGameName;

    private void Start()
    {

    }
    public void GameName()
    {
        SceneManager.LoadScene(NewGameName);
    }
}
