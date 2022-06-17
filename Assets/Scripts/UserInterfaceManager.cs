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
        GetSavedPlayerName();
    }

    public void SetPlayerName()
    {
        currentPlayerName = enterPlayerName_Box.text; 
        playerNameText.text = currentPlayerName;
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("currentPlayerName", playerNameText.text); 
    }

    private void GetSavedPlayerName()
    {
        playerNameText.text = PlayerPrefs.GetString("currentPlayerName"); 
        Debug.Log("name is:" + playerNameText.text);
    }
}