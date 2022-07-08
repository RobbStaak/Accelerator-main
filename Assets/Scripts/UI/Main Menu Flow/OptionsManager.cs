using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    [Header("OPTIONS PANEL - ENABLE/DISABLE")]
    public GameObject OptionsPanel;

    void Start()
    {
        CheckOptionsPanelState();
    }

    public void EnableOptionsPanel()
    {
        OptionsPanel.SetActive(true);
    }

    public void DisableOptionsPanel()
    {
        OptionsPanel.SetActive(false);
    }
    public void CheckOptionsPanelState()
    {
        if (OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanel is: Active");
        }
        else
        {
            Debug.Log("OptionsPanel is: Deactive");
        }
    }
}
