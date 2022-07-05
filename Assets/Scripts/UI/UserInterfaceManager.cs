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
        StartCoroutine(GetGlobalAccess());
    }
    private void Start()
    {
        Debug.Log("Current scene name is: " + scene.name);
    }
    private void Update()
    {
       
    }
    IEnumerator GetGlobalAccess()
    {
        optionsManager = gameObject.GetComponent<OptionsManager>();
        optionsManagerGameScene = gameObject.GetComponent<OptionsManagerGameScene>();
        newGame = gameObject.GetComponent<NewGame>();
        splashScreenManager = gameObject.GetComponent<SplashScreenManager>();
        scene = SceneManager.GetActiveScene();
        loadGame = gameObject.GetComponent<LoadGame>();

        yield return new WaitForSeconds(0.5f);
    }
}