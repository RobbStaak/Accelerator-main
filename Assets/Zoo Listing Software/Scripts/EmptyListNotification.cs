using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyListNotification : MonoBehaviour
{
    private int Coefficient = 0;
    [SerializeField] private GameObject Notification;

    private void Start()
    {
        ZooEmptyListNotificationSystem();
    }

    private void Update()
    {
        
    }

    public void ZooEmptyListNotificationSystem()
    {
        foreach (Transform Child in transform)
        {
            if (Child.gameObject.activeSelf)
            {
                Coefficient = 1;
            }
        }

        if (Coefficient < 1)
        {
            Notification.SetActive(true);
        }
    }
}
