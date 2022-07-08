using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SplashScreenManager : MonoBehaviour
{
    [Header("ACTIVATE - MAIN MENU")]
    public GameObject MainMenu;

    [Header("DEACTIVATE - SPLASH AND HELPER SCREENS")]
    public GameObject SplashScreen;
    public GameObject HelperScreen;

    [Header("SPLASH AND HELPER SCREENS - IMAGE ACTIONS")]
    [SerializeField] private Image SplashScreenImage;
    [SerializeField] private Image HelperScreenImage;

    private void Awake()
    {
        MainMenu.SetActive(false);
        StartCoroutine(ActivateMainMenuRoutine());
    }

    void Start()
    {
        StartCoroutine(DeactivateRaycastTargetFromSplashRoutine());
        StartCoroutine(SplashStateRoutine());
    }

    void Update()
    {
      
    }

    IEnumerator ActivateMainMenuRoutine()
    {
        yield return new WaitForSeconds(2.5f);
        MainMenu.SetActive(true);
    }

    IEnumerator DeactivateRaycastTargetFromSplashRoutine()
    {
        yield return new WaitForSeconds(3.5f);
        SplashScreenImage.raycastTarget = false;
        HelperScreenImage.raycastTarget = false;
    }

    IEnumerator SplashStateRoutine()
    {
        yield return new WaitForSecondsRealtime(0f);

        if (Time.time > 7f)
        {
            SplashScreen.SetActive(false);
            HelperScreen.SetActive(false);
            StopCoroutine(DeactivateRaycastTargetFromSplashRoutine());

            MainMenu.SetActive(true);
            StopCoroutine(ActivateMainMenuRoutine());
        }
    }
}
