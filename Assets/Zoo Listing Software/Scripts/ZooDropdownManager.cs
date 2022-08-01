using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZooDropdownManager : MonoBehaviour
{
    public CategoryDisplay[] CategoryDisplayList = new CategoryDisplay[5];

    public GameObject ZooCategoriesTitle;
    private TMP_Dropdown Sender;
    public TMP_Dropdown DropdownZooArea;
    public ZooListingManager GetZooListingManager;

    private void Start()
    {
        DropdownZooArea.onValueChanged.AddListener(delegate
        {
            DropdownValueChangedHappened(DropdownZooArea);
        });
        ZooCategoriesTitle.SetActive(false);
    }

    public void DropdownValueChangedHappened(TMP_Dropdown Sender)
    {
        if (Sender.value == 0)
        {
            ZooCategoriesTitle.SetActive(false);
        }
        else
        {
            ZooCategoriesTitle.SetActive(true);
        }
        SetAreaCategory();
    }

    public void SetAreaCategory()
    {
        for (int i = 0; i < CategoryDisplayList.Length; i++)
        {
            if (CategoryDisplayList[i].Category.DropdownValue[0] == DropdownZooArea.value)
            {
                CategoryDisplayList[i].gameObject.SetActive(true);
            }
            else if (CategoryDisplayList[i].Category.DropdownValue[1] == DropdownZooArea.value) // Set  All Category/Option
            {
                CategoryDisplayList[i].gameObject.SetActive(true);
            }
            else
            {
                CategoryDisplayList[i].gameObject.SetActive(false);
            }
        }
        GetZooListingManager.SetNoneCategoryList();
    }
}
