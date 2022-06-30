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
    public GameObject MainMenuButtons;


    [Header("DESTROY - SPLASH SCREENS")]
    public GameObject DestroySplashScreen;
    public GameObject DestroyHelperScreen;

    [Header("SPLASH SCREEN IMAGES MANAGER")]
    [SerializeField] private Image SplashScreenImage;
    [SerializeField] private Image HelperScreenImage;


    private void Awake()
    {
        MainMenuButtons.SetActive(false);
    }

    void Start()
    {
        SplashScreenImage = GameObject.Find("Splash Screen").GetComponent<Image>();
        HelperScreenImage = GameObject.Find("Helper Screen").GetComponent<Image>();
    }

    void Update()
    {
        StartCoroutine(SplashFlow());

        if(Time.time > 7f)
        {
            StopCoroutine(SplashFlow());
        }
    }

    private void ToDestroy()
    {
        Destroy(DestroySplashScreen);
        Destroy(DestroyHelperScreen);
    }

    IEnumerator SplashFlow()
    {
        if (Time.time > 3f)
        {
            MainMenuButtons.SetActive(true);
        }

        if (Time.time > 4.5f)
        {
            SplashScreenImage.raycastTarget = false;
            HelperScreenImage.raycastTarget = false;
        }


        if (Time.time > 6.5f)
        {
            ToDestroy();
        }

        yield return new WaitForSeconds(0f);
    }

}
