using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cloth_0", menuName = "Clothes/Cloth", order = 1)]
public class PlayerCloth : ScriptableObject
{
    public Sprite Idle;
    public List<Sprite> Up = new List<Sprite>();
    public List<Sprite> Down = new List<Sprite>();
    public List<Sprite> Left = new List<Sprite>();
    public List<Sprite> Right = new List<Sprite>();

    public Color clothColor;

    
}
