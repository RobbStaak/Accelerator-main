using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionsManagerGameScene : MonoBehaviour
{
    [Header("OPTIONS - GAME PLACEHOLDER FLOW")]
    [Header("OPTIONS - MAIN FLOW")]
    public GameObject OptionsPanel;

    [Header("OPTIONS - ADDITIONAL FLOW")]
    [SerializeField] private GameObject BackToMenu;

    void Start()
    {
        CheckOptionsPanelGameScene();
    }
    public void OptionsPanelEnable()
    {
        OptionsPanel.SetActive(true);
        BackToMenu.GetComponent<Button>().enabled = false;
    }

    public void OptionsPanelDisable()
    {
        OptionsPanel.SetActive(false);
        BackToMenu.GetComponent<Button>().enabled = true;
    }
    public void CheckOptionsPanelGameScene()
    {
        if (UserInterfaceManager.Instance.optionsManagerGameScene.OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanelGameScene is: Active");
        }
        else
        {
            Debug.Log("OptionsPanelGameScene is: Deactive");
        }
    }
}
