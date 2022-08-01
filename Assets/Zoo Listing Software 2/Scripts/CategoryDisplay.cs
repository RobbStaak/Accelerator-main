using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CategoryDisplay : MonoBehaviour
{
    public Category Category;
    public TMP_Text NameText;

    void Start()
    {
        NameText.text = Category.name;
    }
}