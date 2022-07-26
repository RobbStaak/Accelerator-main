using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZooListingManager : MonoBehaviour
{
    [SerializeField] private Canvas[] Lists = new Canvas[5];

    private void Start()
    {
        CheckForNullReference();
    }

    private void Update()
    {
        
    }

    public void SetNoneCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].enabled != false)
            {
                Lists[i].enabled = false;
            }
        }
    }

    public void SetDomesticCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].gameObject.name != "Domestic_List_Canvas")
            {
                if (Lists[i].gameObject.activeInHierarchy)
                {
                    Lists[i].enabled = false;
                }
            }
            else
            {
                Lists[i].enabled = true;
            }
        }
    }

    public void SetFishCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].gameObject.name != "Fish_List_Canvas")
            {
                if (Lists[i].gameObject.activeInHierarchy)
                {
                    Lists[i].enabled = false;
                }
            }
            else
            {
                Lists[i].enabled = true;
            }
        }
    }

    public void SetSharkCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].gameObject.name != "Shark_List_Canvas")
            {
                if (Lists[i].gameObject.activeInHierarchy)
                {
                    Lists[i].enabled = false;
                }
            }
            else
            {
                Lists[i].enabled = true;
            }
        }
    }

    public void SetInsectCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].gameObject.name != "Insect_List_Canvas")
            {
                if (Lists[i].gameObject.activeInHierarchy)
                {
                    Lists[i].enabled = false;
                }
            }
            else
            {
                Lists[i].enabled = true;
            }
        }
    }

    public void SetMonkeyCategoryList()
    {
        for (int i = 0; i < Lists.Length; i++)
        {
            if (Lists[i].gameObject.name != "Monkey_List_Canvas")
            {
                if (Lists[i].gameObject.activeInHierarchy)
                {
                    Lists[i].enabled = false;
                }
            }
            else
            {
                Lists[i].enabled = true;
            }
        }
    }

    private void CheckForNullReference()
    {
        if (Lists[0] == null)
        {
            var FindDomesticListCanvas = GameObject.Find("Domestic_List_Canvas");
            Lists[0] = FindDomesticListCanvas.GetComponent<Canvas>();
        }

        if (Lists[1] == null)
        {
            var FindFishListCanvas = GameObject.Find("Fish_List_Canvas");
            Lists[1] = FindFishListCanvas.GetComponent<Canvas>();
        }

        if (Lists[2] == null)
        {
            var FindSharkListCanvas = GameObject.Find("Shark_List_Canvas");
            Lists[2] = FindSharkListCanvas.GetComponent<Canvas>();
        }

        if (Lists[3] == null)
        {
            var FindInsectListCanvas = GameObject.Find("Insect_List_Canvas");
            Lists[3] = FindInsectListCanvas.GetComponent<Canvas>();
        }

        if (Lists[4] == null)
        {
            var FindMonkeyListCanvas = GameObject.Find("Monkey_List_Canvas");
            Lists[4] = FindMonkeyListCanvas.GetComponent<Canvas>();
        }
    }
}
