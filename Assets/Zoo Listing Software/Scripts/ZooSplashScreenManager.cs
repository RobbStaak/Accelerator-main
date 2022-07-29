using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ZooSplashScreenManager : MonoBehaviour
{
    [Header("SPLASH SCREEN - ACTIONS")]
    [SerializeField] private Canvas ZooSplashScreen;
    [SerializeField] private Animator ZooSplashBackgroundAnimator;
    [SerializeField] private Animator ZooSplashIconAnimator;
    [SerializeField] private Animator ZooSplashTextAnimator;
    [SerializeField] private Animator HelperScreenAnimator;

    [Header("ZOO SCREENS - ACTIONS")]
    [SerializeField] private Canvas ZooBackgroundCanvas;
    [SerializeField] private Canvas ZooAreaCanvas;
    [SerializeField] private Canvas ZooCategoriesCanvas;
    [SerializeField] private Image ExitZooOption;

    private void Start()
    {
        CheckForNullReference();
        StartCoroutine(SetUpSplash());
        StartCoroutine(SetUpZooScreens());
        StartCoroutine(SetExitZooOptionRaycastTarget());
    }

    private IEnumerator SetUpSplash()
    {
        yield return new WaitForSeconds(5.9f);

        ZooSplashScreen.enabled = false;
        ZooSplashBackgroundAnimator.enabled = false;
        ZooSplashIconAnimator.enabled = false;
        ZooSplashTextAnimator.enabled = false;
        HelperScreenAnimator.enabled = false;
    }

    private IEnumerator SetUpZooScreens()
    {
        yield return new WaitForSeconds(1.5f);

        ZooBackgroundCanvas.enabled = true;
        ZooAreaCanvas.enabled = true;
        ZooCategoriesCanvas.enabled = true;
        ExitZooOption.enabled = true;
    }

    private IEnumerator SetExitZooOptionRaycastTarget()
    {
        yield return new WaitForSeconds(4f);

        ExitZooOption.raycastTarget = true;
    }

    private void CheckForNullReference()
    {
        if (ExitZooOption == null)
        {
            var FindExitZooOption = GameObject.Find("Exit Zoo");
            ExitZooOption = FindExitZooOption.GetComponent<Image>();
        }

        if (ZooSplashScreen == null)
        {
            var FindZooSplashScreen = gameObject.GetComponent<Canvas>();
            ZooSplashScreen = FindZooSplashScreen;
        }

        if (ZooSplashBackgroundAnimator == null)
        {
            var FindZooBackgroundAnimator = gameObject.transform.GetChild(0);
            ZooSplashBackgroundAnimator = FindZooBackgroundAnimator.GetComponent<Animator>();
        }

        if (ZooSplashIconAnimator == null)
        {
            var FindZooIconAnimator = gameObject.transform.GetChild(1);
            ZooSplashIconAnimator = FindZooIconAnimator.GetComponent<Animator>();
        }

        if (ZooSplashTextAnimator == null)
        {
            var FindZooTextAnimator = gameObject.transform.GetChild(2);
            ZooSplashTextAnimator = FindZooTextAnimator.GetComponent<Animator>();
        }

        if (HelperScreenAnimator == null)
        {
            var FindHelperScreenAnimator = gameObject.transform.GetChild(3);
            HelperScreenAnimator = FindHelperScreenAnimator.GetComponent<Animator>();
        }

        if (ZooBackgroundCanvas == null)
        {
            var FindZooBackgroundCanvas = GameObject.Find("Zoo Background_Canvas");
            ZooBackgroundCanvas = FindZooBackgroundCanvas.GetComponent<Canvas>();
        }

        if (ZooAreaCanvas == null)
        {
            var FindZooAreaCanvas = GameObject.Find("Zoo Area_Canvas");
            ZooAreaCanvas = FindZooAreaCanvas.GetComponent<Canvas>();
        }

        if (ZooCategoriesCanvas == null)
        {
            var FindZooCategoriesCanvas = GameObject.Find("Zoo Categories_Canvas");
            ZooCategoriesCanvas = FindZooCategoriesCanvas.GetComponent<Canvas>();
        }
    }
}
