using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bug", menuName = "Bugs")]
public class Bug : ScriptableObject
{
    public string bugName;
    public string description;

    public Sprite artwork;
    public Sprite itemIcon;
}
