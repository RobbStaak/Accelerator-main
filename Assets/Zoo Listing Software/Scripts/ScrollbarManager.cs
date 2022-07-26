using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarManager : MonoBehaviour
{
    [SerializeField] private Scrollbar ThisScrollbar;

    private void Start()
    {
        if (ThisScrollbar == null)
        {
            var FindScrollbar = gameObject.GetComponent<Scrollbar>();
            ThisScrollbar = FindScrollbar;
        }
    }

    private void Update()
    {
        
    }

    public void SetScrollbarValue()
    {
        ThisScrollbar.value = 1;
    }
}
