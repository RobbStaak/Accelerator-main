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
    public string NewGameName;

    private void Start()
    {
        if(NewGameName != "Game")
        {
            NewGameActions(); // Tests
        }
    }
    public void GameName()
    {
        SceneManager.LoadScene(NewGameName);
    }
    private void NewGameActions()
    {
        Image NewGameImage = UserInterfaceManager.Instance.optionsManager.NewGame.GetComponent<Image>();
        NewGameImage.color = Color.red; // Tests
    }
}
