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

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    public void EnableButton()
    {
        BackToMenuButton.enabled = true;
    }
    public void DisableButton()
    {
        BackToMenuButton.enabled = false;
    }
}
