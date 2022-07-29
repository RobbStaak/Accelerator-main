using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyListNotification : MonoBehaviour
{
    private bool IsNotificationActive = true;
    [SerializeField] private GameObject Notification;

    private void Start()
    {
        ZooEmptyListNotificationSystem();
    }

    public void ZooEmptyListNotificationSystem()
    {
        foreach (Transform Child in transform)
        {
            if (Child.gameObject.activeSelf)
            {
                IsNotificationActive = false;
            }
        }

        if (IsNotificationActive != false)
        {
            Notification.SetActive(true);
        }
    }
}
