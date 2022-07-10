using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuButtonsManager : MonoBehaviour
{
    [Header("MAIN MENU BUTTONS - ENABLE/DISABLE")]
    public Button NewGameButton;
    public Button LoadGameButton;
    public Button OptionsButton;
    public Button ExitButton;

    [Header("MAIN MENU BUTTONS - IMAGE ACTIONS")]
    private Image OptionsButtonImage;

    private void Start()
    {

    }

    private void Update()
    {

    }

    public void DisableButtons()
    {
        NewGameButton.enabled = false;
        LoadGameButton.enabled = false;
        OptionsButton.enabled = false;
        ExitButton.enabled = false;
        OptionsButtonActions();
    }
    public void EnableButtons()
    {
        NewGameButton.enabled = true;
        LoadGameButton.enabled = true;
        OptionsButton.enabled = true;
        ExitButton.enabled = true;
        OptionsButtonActions();
    }

    public void OptionsButtonActions()
    {
        if (UserInterfaceManager.Instance.GetMainMenuOptionsManager.OptionsPanel.activeInHierarchy)
        {
            OptionsButtonImage = OptionsButton.image;
            OptionsButtonImage.color = Color.green;
        }
        else
        {
            OptionsButtonImage.color = Color.white;
        }
    }
}
