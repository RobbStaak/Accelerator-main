using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSceneOptionsManager : MonoBehaviour
{
    [Header("OPTIONS PANEL - ENABLE/DISABLE")]
    public GameObject OptionsPanel;

    private void Start()
    {

    }
    public void EnableOptionsPanel()
    {
        OptionsPanel.SetActive(true);
        UserInterfaceManager.Instance.ScreenStateID = 3;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
    }

    public void DisableOptionsPanel()
    {
        OptionsPanel.SetActive(false);
        UserInterfaceManager.Instance.ScreenStateID = -3;
        UserInterfaceManager.Instance.CheckCurrentScreenState();
    }
}
