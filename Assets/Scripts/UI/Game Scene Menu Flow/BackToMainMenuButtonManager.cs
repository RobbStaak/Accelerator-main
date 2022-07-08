using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BackToMainMenuButtonManager : MonoBehaviour
{
    [Header("BACK TO MENU BUTTON - ENABLE/DISABLE")]
    [SerializeField] private Button BackToMenuButton;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void EnableButton()
    {
        BackToMenuButton.GetComponent<Button>().enabled = true;
        UserInterfaceManager.Instance.GetOptionsManagerGameScene.CheckOptionsPanelGameScene();
    }
    public void DisableButton()
    {
        BackToMenuButton.GetComponent<Button>().enabled = false;
        UserInterfaceManager.Instance.GetOptionsManagerGameScene.CheckOptionsPanelGameScene();
    }
}
