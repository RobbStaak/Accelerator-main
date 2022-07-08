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

    [HideInInspector] public NewGameSceneManager GetNewGameSceneManager;
    [HideInInspector] public LoadGameSceneManager GetLoadGameSceneManager;
    [HideInInspector] public OptionsManager GetOptionsManager;
    [HideInInspector] public OptionsManagerGameScene GetOptionsManagerGameScene;
    [HideInInspector] public MainMenuButtonsManager GetMainMenuButtonsManager;
    [HideInInspector] public BackToMainMenuButtonManager GetBackToMainMenuButtonManager;
    [HideInInspector] public SplashScreenManager GetSplashScreenManager;
    [HideInInspector] public Scene GetScene;

    private void Awake()
    {
        Instance = this;
        StartCoroutine(GetGlobalAccess());
    }
    private void Start()
    {
        Debug.Log("Current scene name is: " + GetScene.name);
    }
    private void Update()
    {
       
    }
    IEnumerator GetGlobalAccess()
    {
        GetNewGameSceneManager = gameObject.GetComponent<NewGameSceneManager>();
        GetLoadGameSceneManager = gameObject.GetComponent<LoadGameSceneManager>();
        GetOptionsManager = gameObject.GetComponent<OptionsManager>();
        GetOptionsManagerGameScene = gameObject.GetComponent<OptionsManagerGameScene>();
        GetMainMenuButtonsManager = gameObject.GetComponent<MainMenuButtonsManager>();
        GetBackToMainMenuButtonManager = gameObject.GetComponent<BackToMainMenuButtonManager>();
        GetSplashScreenManager = gameObject.GetComponent<SplashScreenManager>();
        GetScene = SceneManager.GetActiveScene();

        yield return new WaitForSeconds(0.5f);
    }
}