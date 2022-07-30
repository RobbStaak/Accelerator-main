using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZooDropdownManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown DropdownZooArea;
    private TMP_Dropdown Sender;
    [SerializeField] private ZooListingManager GetZooListingManager;
    [SerializeField] private GameObject ZooCategoriesTitle;
    [SerializeField] private Transform CategoriesTransform;

    private void Start()
    {
        CheckForNullReference();
        DropdownZooArea.onValueChanged.AddListener(delegate
        {
            DropdownValueChangedHappened(DropdownZooArea);            
        });
        ZooCategoriesTitle.SetActive(false);
    }

    public void DropdownValueChangedHappened(TMP_Dropdown Sender)
    {
        SetAreaCategory(Sender);
        if (Sender.value == 0)
        {
            ZooCategoriesTitle.SetActive(false);
        }
        else
        {
            ZooCategoriesTitle.SetActive(true);
        }
    }

    public void SetAreaCategory(TMP_Dropdown Sender)
    {
        foreach (Transform Child in CategoriesTransform)
        {
            Child.gameObject.SetActive(false);

            if (Sender.value == 0) // None Area
            {
                if (Child.gameObject.activeInHierarchy)
                {
                    Child.gameObject.SetActive(false);
                }
            }
            else if (Sender.value == 1) // Entry Area
            {
                if (Child.gameObject.tag == "EntryArea")
                {
                    Child.gameObject.SetActive(true);
                }
            }
            else if (Sender.value == 2) // Underwater Area
            {
                if (Child.gameObject.tag == "UnderwaterArea")
                {
                    Child.gameObject.SetActive(true);
                }
            }
            else if (Sender.value == 3) // Jungle Area
            {
                if (Child.gameObject.tag == "JungleArea")
                {
                    Child.gameObject.SetActive(true);
                }
            }
            else if (Sender.value == 4) // All Areas
            {
                Child.gameObject.SetActive(true);
            }

            GetZooListingManager.SetNoneCategoryList();
        }
    }
   
    private void CheckForNullReference()
    {
        if (DropdownZooArea == null)
        {
            var FindDropdownZooArea = gameObject.transform.GetChild(2);
            DropdownZooArea = FindDropdownZooArea.GetComponent<TMP_Dropdown>();
        }

        if (GetZooListingManager == null)
        {
            var FindZooListingManager = GameObject.Find("Zoo Categories_Canvas");
            GetZooListingManager = FindZooListingManager.GetComponent<ZooListingManager>();
        }

        if (ZooCategoriesTitle == null)
        {
            var FindZooCategoriesTitle = GameObject.Find("Zoo_Categories_Panel").transform.GetChild(0);
            ZooCategoriesTitle = FindZooCategoriesTitle.gameObject;
        }

        if (CategoriesTransform == null)
        {
            var FindCategoriesTransform = GameObject.Find("Categories");
            CategoriesTransform = FindCategoriesTransform.GetComponent<Transform>();
        }
    }
}
