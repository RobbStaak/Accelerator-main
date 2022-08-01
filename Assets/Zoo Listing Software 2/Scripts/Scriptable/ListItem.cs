using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ListItem : ScriptableObject
{
    public new string name;
    public Sprite artwork;
}
