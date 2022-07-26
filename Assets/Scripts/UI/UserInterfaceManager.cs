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

    [Header("MAIN MENU")]
    public SplashScreenManager GetSplashScreenManager;
    public NewGameSceneManager GetNewGameSceneManager;
    public MainMenuOptionsManager GetMainMenuOptionsManager;
    public ExitGameManager GetExitGameManager;
    public MainMenuButtonsManager GetMainMenuButtonsManager;

    [Header("GAME SCENE")]
    public GameSceneOptionsManager GetGameSceneOptionsManager;
    public BackToMainMenuButtonManager GetBackToMainMenuButtonManager;

    [Header("ALL SCENES")]
    public LoadGameSceneManager GetLoadGameSceneManager;
    public Scene GetScene;

    [HideInInspector] public int ScreenStateID; // 1,-1 MainMeniOptionsPanel, 2,-2 MainMenu, 3,-3 GameSceneOptionsPanel
     
    private void Awake()
    {
        Instance = this;
        GetScene = SceneManager.GetActiveScene();
    }
    private void Start()
    {
        CheckForNullReference();
        CheckCurrentScreenState();
        Debug.Log("Current scene name is: " + GetScene.name);
    }
    private void Update()
    {

    }

    public void CheckCurrentScreenState()
    {
        if (GetScene.name == "MainMenu")
        {
            if (ScreenStateID == 1)
            {
                Debug.Log("MainMenuOptionsPanel is: Open");
            }
            else if (ScreenStateID == -1)
            {
                Debug.Log("MainMenuOptionsPanel is: Close");
            }

            if (ScreenStateID == 2)
            {
                Debug.Log("MainMenu is: Open");
            }
            else if (ScreenStateID == -2)
            {
                Debug.Log("MainMenu is: Close");
            }
        }
        
        if (GetScene.name == "Game")
        {
            if (ScreenStateID == 3)
            {
                Debug.Log("GameSceneOptionsPanel is: Open");
            }
            else if (ScreenStateID == -3)
            {
                Debug.Log("GameSceneOptionsPanel is: Close");
            }
        }
    }

    public enum ScreenState
    {
        MainMenuOptionsPanel_Open = 1,
        MainMenuOptionsPanel_Close = -1,

        MainMenu_Open = 2,
        MainMenu_Close = -2,

        GameSceneOptionsPanel_Open = 3,
        GameSceneOptionsPanel_Close = -3
    }
    private void CheckForNullReference()
    {
        if (GetScene.name == "Main Menu")
        {
            if (GetSplashScreenManager == null)
            {
                var FindSplashScreenManager = gameObject.GetComponent<SplashScreenManager>();
                GetSplashScreenManager = FindSplashScreenManager;
            }

            if (GetNewGameSceneManager == null)
            {
                var FindNewGameSceneManager = gameObject.GetComponent<NewGameSceneManager>();
                GetNewGameSceneManager = FindNewGameSceneManager;
            }

            if (GetMainMenuOptionsManager == null)
            {
                var FindMainMenuOptionsManager = gameObject.GetComponent<MainMenuOptionsManager>();
                GetMainMenuOptionsManager = FindMainMenuOptionsManager;
            }

            if (GetExitGameManager == null)
            {
                var FindExitGameManager = gameObject.GetComponent<ExitGameManager>();
                GetExitGameManager = FindExitGameManager;
            }

            if (GetMainMenuButtonsManager == null)
            {
                var FindMainMenuButtonsManager = gameObject.GetComponent<MainMenuButtonsManager>();
                GetMainMenuButtonsManager = FindMainMenuButtonsManager;
            }
        }

        if (GetScene.name == "Game")
        {
            if (GetGameSceneOptionsManager == null)
            {
                var FindGameSceneOptionsManager = gameObject.GetComponent<GameSceneOptionsManager>();
                GetGameSceneOptionsManager = FindGameSceneOptionsManager;
            }

            if (GetBackToMainMenuButtonManager == null)
            {
                var FindBackToMenuButtonManager = gameObject.GetComponent<BackToMainMenuButtonManager>();
                GetBackToMainMenuButtonManager = FindBackToMenuButtonManager;
            }
        }

        if (GetLoadGameSceneManager == null)
        {
            var FindLoadGameSceneManager = gameObject.GetComponent<LoadGameSceneManager>();
            GetLoadGameSceneManager = FindLoadGameSceneManager;
        }
    }
}