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
    [SerializeField] private GameObject _BackToMenu;

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void OptionsPanelEnable()
    {
        OptionsPanel.SetActive(true);

        _BackToMenu.GetComponent<Button>().enabled = false;
    }

    public void OptionsPanelDisable()
    {
        OptionsPanel.SetActive(false);

        _BackToMenu.GetComponent<Button>().enabled = true;
    }
}
