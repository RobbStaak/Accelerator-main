using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI playerNameText;
    private string currentPlayerName;


    [SerializeField]
    private TMP_InputField enterPlayerName_Box;


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
        currentPlayerName = enterPlayerName_Box.text; 
        playerNameText.text = currentPlayerName;
    }

    private void SavePlayerName()
    {
        
        PlayerPrefs.SetString(currentPlayerName, playerNameText.text); 
        PlayerPrefs.Save();
    }

    private string GetSavedPlayerName()
    {
        PlayerPrefs.GetString(currentPlayerName, playerNameText.text); 
        Debug.Log("name is:" + playerNameText.text);

        return playerNameText.text;

    }
}