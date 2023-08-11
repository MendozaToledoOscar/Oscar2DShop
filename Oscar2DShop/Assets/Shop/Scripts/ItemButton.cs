using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum MyClothtypes
{
    Head, Top, Pants
}

public class ItemButton : MonoBehaviour
{
    public PlayerCloth cloth;
    public int cost;
    public MyClothtypes clothType;
    public Text description;
    public bool defalutImage = false;


    private Image image;

    private void Start()
    {
        image = GetComponentInChildren<Image>();
        description.text = cost.ToString();
        if(!defalutImage)
            image.sprite = cloth.Idle;
        image.color = cloth.clothColor;
    }

    public void SelectItem()
    {
        description.text = "Wear";
        AnimatedCloth animCloth = GameObject.FindGameObjectWithTag(clothType.ToString()).GetComponent<AnimatedCloth>();
        animCloth.ChangeCloth(cloth);
    }

}
