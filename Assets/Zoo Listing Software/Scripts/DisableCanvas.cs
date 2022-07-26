using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCanvas : MonoBehaviour
{
    [SerializeField] private Canvas ThisCanvas;

    private void Start()
    {
        if (ThisCanvas == null)
        {
            var FindCanvas = gameObject.GetComponent<Canvas>();
            ThisCanvas = FindCanvas;
        }
    }

    private void Update()
    {
        
    }

    public void DisableCanvasList()
    {
        ThisCanvas.enabled = false;
    }
}
