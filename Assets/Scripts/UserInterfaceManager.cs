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
        playerNameText.text = currentPlayerName;
    }

    private void SavePlayerName()
    {
        
    }

    private string GetSavedPlayerName()
    {
        
    }
}