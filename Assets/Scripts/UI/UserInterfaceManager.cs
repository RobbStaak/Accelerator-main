using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }


    [HideInInspector] public NewGame newGame;
    [HideInInspector] public LoadGame loadGame;
    [HideInInspector] public OptionsManager optionsManager;
    [HideInInspector] public OptionsManagerGameScene optionsManagerGameScene;
    [HideInInspector] public SplashScreenManager splashScreenManager;
    [HideInInspector] public Scene scene;


    private void Awake()
    {
        Instance = this;

        optionsManager = GameObject.Find("User_Interface_Manager").GetComponent<OptionsManager>();
        optionsManagerGameScene = gameObject.GetComponent<OptionsManagerGameScene>();
        newGame = GameObject.Find("User_Interface_Manager").GetComponent<NewGame>();
        splashScreenManager = GameObject.Find("User_Interface_Manager").GetComponent<SplashScreenManager>();
        scene = SceneManager.GetActiveScene();
        loadGame = GameObject.Find("User_Interface_Manager").GetComponent<LoadGame>();

    }

    private void Start()
    {

    }

    private void Update()
    {
        if (UserInterfaceManager.Instance.scene.name == "Main Menu")
        {
            Debug.Log("Current scene name is: Main Menu ");

            CheckNewGameName(); // Spell checker 
            CheckOptionsPanel();
            CheckSplashScreen();
        }
        else if(UserInterfaceManager.Instance.scene.name != "Main Menu")
        {
            Debug.Log("Current scene name is: " + scene.name);
            CheckOptionsPanelGameScene();
            CheckLoadGameName(); // Spell checker // Back to Main Menu scene name
        }
    }

    private void CheckOptionsPanel()
    {
        if (UserInterfaceManager.Instance.optionsManager.OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanel is: Active");
        }
    }

    private void CheckNewGameName()
    {

        if (UserInterfaceManager.Instance.newGame._NewGameName == "Game")
        {
            Debug.Log("The name of the 'NewGame' is spelled: Correct");
        }
        else
        {
            Debug.Log("The name of the 'NewGame' is spelled: Wrong");
        }
    }


    private void CheckSplashScreen()
    {
        if (UserInterfaceManager.Instance.splashScreenManager.DestroySplashScreen != false)
        {
            Debug.Log("Splash screen is: Active");
        }
        else
        {
            Debug.Log("Splash screen is: Deactive");
        }
    }

    private void CheckOptionsPanelGameScene()
    {
        if (UserInterfaceManager.Instance.optionsManagerGameScene.OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanelGameScene is: Active");
        }

    }

    private void CheckLoadGameName()
    {
        if (UserInterfaceManager.Instance.loadGame._LoadGameName == "Main Menu")
        {
            Debug.Log("The name of the 'LoadGame' is spelled: Correct");
        }
        else
        {
            Debug.Log("The name of the 'LoadGame' is spelled: Wrong");
        }
    }
}