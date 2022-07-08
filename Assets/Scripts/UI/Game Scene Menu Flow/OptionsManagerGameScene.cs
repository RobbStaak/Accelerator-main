using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionsManagerGameScene : MonoBehaviour
{
    [Header("OPTIONS PANEL - ENABLE/DISABLE")]
    public GameObject OptionsPanel;

    void Start()
    {
        CheckOptionsPanelGameScene();
    }
    public void EnableOptionsPanel()
    {
        OptionsPanel.SetActive(true);
    }

    public void DisableOptionsPanel()
    {
        OptionsPanel.SetActive(false);
    }
    public void CheckOptionsPanelGameScene()
    {
        if (OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanelGameScene is: Active");
        }
        else
        {
            Debug.Log("OptionsPanelGameScene is: Deactive");
        }
    }
}
