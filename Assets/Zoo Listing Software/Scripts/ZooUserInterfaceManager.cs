using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ZooUserInterfaceManager : MonoBehaviour
{
    public static ZooUserInterfaceManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {

    }

    private void Update()
    {
        
    }
}
