using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class OptionsManager : MonoBehaviour
{
    [Header("OPTIONS - MAIN FLOW")]
    public GameObject OptionsPanel;

    [Header("OPTIONS - ADDITIONAL FLOW")]
    public GameObject NewGame; // Tests
    [SerializeField] private GameObject LoadGame;
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject Exit;

    void Start()
    {
        CheckOptionsPanel();
    }

    public void OptionsPanelEnable()
    {
        OptionsPanel.SetActive(true);
        NewGame.GetComponent<Button>().enabled = false;
        LoadGame.GetComponent<Button>().enabled = false;
        Options.GetComponent<Button>().enabled = false;
        Exit.GetComponent<Button>().enabled = false;
    }

    public void OptionsPanelDisable()
    {
        OptionsPanel.SetActive(false);
        NewGame.GetComponent<Button>().enabled = true;
        LoadGame.GetComponent<Button>().enabled = true;
        Options.GetComponent<Button>().enabled = true;
        Exit.GetComponent<Button>().enabled = true;
    }

    public void CheckOptionsPanel()
    {
        if (UserInterfaceManager.Instance.optionsManager.OptionsPanel.activeInHierarchy)
        {
            Debug.Log("OptionsPanel is: Active");
        }
        else
        {
            Debug.Log("OptionsPanel is: Deactive");
        }
    }
}
