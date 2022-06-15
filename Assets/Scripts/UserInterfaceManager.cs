using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI playerNameText;
    private string currentPlayerName;

    [SerializeField]
    private TextMeshProUGUI enterPlayerName;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentPlayerName = GetSavedPlayerName();
    }

    public void SetPlayerName()
    {
        currentPlayerName = enterPlayerName.text;
        playerNameText.text = currentPlayerName;
    }

    private void SavePlayerName()
    {
        PlayerPrefs.GetString(currentPlayerName, playerNameText.text);
        Debug.Log("Is player name saved:" + currentPlayerName);

    }

    private string GetSavedPlayerName()
    {
        PlayerPrefs.SetString(currentPlayerName, playerNameText.text);
        Debug.Log("name is:" + currentPlayerName);


        return null;
    }
}