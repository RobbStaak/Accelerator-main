using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuButtonsManager : MonoBehaviour
{
    [Header("MAIN MENU BUTTONS - ENABLE/DISABLE")]
    public Button NewGameButton; // Test
    [SerializeField] private Button LoadGameButton;
    [SerializeField] private Button OptionsButton;
    [SerializeField] private Button ExitButton;

    [Header("MAIN MENU BUTTONS - IMAGE ACTIONS")]
    private Image NewGameButtonImage;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void DisableButtons()
    {
        NewGameButton.GetComponent<Button>().enabled = false;
        LoadGameButton.GetComponent<Button>().enabled = false;
        OptionsButton.GetComponent<Button>().enabled = false;
        ExitButton.GetComponent<Button>().enabled = false;
        UserInterfaceManager.Instance.GetOptionsManager.CheckOptionsPanelState();//Test
    }
    public void EnableButtons()
    {
        NewGameButton.GetComponent<Button>().enabled = true;
        LoadGameButton.GetComponent<Button>().enabled = true;
        OptionsButton.GetComponent<Button>().enabled = true;
        ExitButton.GetComponent<Button>().enabled = true;
        UserInterfaceManager.Instance.GetOptionsManager.CheckOptionsPanelState();//Test
    }
    
    public void NewGameButtonActions()
    {
        NewGameButtonImage = NewGameButton.GetComponent<Image>();
        NewGameButtonImage.color = Color.red; // Test
    }
}
