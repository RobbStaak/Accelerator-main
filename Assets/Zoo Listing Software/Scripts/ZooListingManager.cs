using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZooListingManager : MonoBehaviour
{
    [SerializeField] private Canvas[] ZooLists = new Canvas[5];

    public void SetNoneCategoryList()
    {
        for (int i = 0; i < ZooLists.Length; i++)
        {
            if (ZooLists[i].enabled != false)
            {
                ZooLists[i].enabled = false;
            }
        }
    }

    public void SetCategoryList(Canvas List)
    {
        for (int i = 0; i < ZooLists.Length; i++)
        {
            if (ZooLists[i] != List)
            {
                if (ZooLists[i].gameObject.activeInHierarchy)
                {
                    ZooLists[i].enabled = false;
                }
            }
            else
            {
                ZooLists[i].enabled = true;
            }
        }
    }
}
