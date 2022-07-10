using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuOptionsManager : MonoBehaviour
{
    [Header("OPTIONS PANEL - ENABLE/DISABLE")]
    public GameObject OptionsPanel;

    private void Start()
    {
       
    }

    public void EnableOptionsPanel()
    {
        OptionsPanel.SetActive(true);
        UserInterfaceManager.Instance.ScreenStateID = 1;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
        UserInterfaceManager.Instance.ScreenStateID = -2;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
    }

    public void DisableOptionsPanel()
    {
        OptionsPanel.SetActive(false);
        UserInterfaceManager.Instance.ScreenStateID = -1;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
        UserInterfaceManager.Instance.ScreenStateID = 2;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
    }
}
