using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Category", menuName = "Category")]
public class Category : ScriptableObject
{
    public new string name;
    public int[] DropdownValue = new int[2];
}
