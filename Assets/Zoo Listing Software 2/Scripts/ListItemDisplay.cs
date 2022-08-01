using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ListItemDisplay : MonoBehaviour
{
    public ListItem ListItem;
    public TMP_Text NameText;
    public Image ArtworkImage;

    void Start()
    {
        NameText.text = ListItem.name;
        ArtworkImage.sprite = ListItem.artwork;
    }
}
