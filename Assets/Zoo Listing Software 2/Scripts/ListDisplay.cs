using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ListDisplay : MonoBehaviour
{
    public List List;
    public TMP_Text NameText;

    void Start()
    {
        NameText.text = List.name;
    }
}
