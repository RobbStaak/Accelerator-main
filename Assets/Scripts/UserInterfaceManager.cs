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
    private string defValue = "Guest";

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

        if(playerNameText.text == "")
        {
            playerNameText.text = defValue;
        }
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("SavePlayerName", playerNameText.text);
    }

    private void GetSavedPlayerName()
    {
        playerNameText.text = PlayerPrefs.GetString("SavePlayerName", default);
    }

    public void CheckGoogleClock()
    {
        Application.OpenURL("https://www.google.com/search?q=+time&sxsrf=ALiCzsYjAdnvmbZ3F4Ok7IqNMC0GS8DJCQ%3A1655827079202&ei=h-qxYpDoC7OIxc8PjIOdUA&ved=0ahUKEwjQx_XG9L74AhUzRPEDHYxBBwoQ4dUDCA4&uact=5&oq=+time&gs_lcp=Cgdnd3Mtd2l6EAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAELADEEMyBwgAELADEENKBAhBGABKBAhGGABQwwVYwwVgwwZoAnABeACAAQCIAQCSAQCYAQCgAQHIAQrAAQE&sclient=gws-wiz");
    }


    public void ResetChanges()
    {
        playerNameText.text = defValue;
        enterPlayerName_Box.text = "";
        var ResetPlayerEnterValue = GameObject.Find("User_Interface_Manager").GetComponent<UIPlayerEnterValueAndClock>().PlayerEnterValue;
        ResetPlayerEnterValue.text = 0.ToString();

        PlayerPrefs.DeleteAll();
    }

    public void ButtonChangeReset()
    {
        enterPlayerName_Box.text = "";
    }
}