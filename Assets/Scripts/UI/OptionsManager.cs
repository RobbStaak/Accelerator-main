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
    [SerializeField] private GameObject _NewGame;
    [SerializeField] private GameObject _LoadGame;
    [SerializeField] private GameObject _Options;
    [SerializeField] private GameObject _Exit;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OptionsPanelEnable()
    {
        OptionsPanel.SetActive(true);

        _NewGame.GetComponent<Button>().enabled = false;
        _LoadGame.GetComponent<Button>().enabled = false;
        _Options.GetComponent<Button>().enabled = false;
        _Exit.GetComponent<Button>().enabled = false;
    }

    public void OptionsPanelDisable()
    {
        OptionsPanel.SetActive(false);

        _NewGame.GetComponent<Button>().enabled = true;
        _LoadGame.GetComponent<Button>().enabled = true;
        _Options.GetComponent<Button>().enabled = true;
        _Exit.GetComponent<Button>().enabled = true;
    }
}
