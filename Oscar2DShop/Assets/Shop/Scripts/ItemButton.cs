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
    private PlayerCoins playerCoins;
    private AnimatedCloth animCloth;

    private void Start()
    {
        playerCoins = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoins>();
        image = GetComponentInChildren<Image>();
        description.text = cost.ToString();
        if(!defalutImage)
            image.sprite = cloth.Idle;
        image.color = cloth.clothColor;
    }

    public void SelectItem()
    {
        if(description.text == "Wear")
        {
            ChangeItemCloth();
        }
        else if(playerCoins.numberOfCoins - cost >= 0)
        {
            playerCoins.UpdateCoins(-cost);
            description.text = "Wear";
            ChangeItemCloth();
        }
    }

    private void ChangeItemCloth()
    {
        animCloth = GameObject.FindGameObjectWithTag(clothType.ToString()).GetComponent<AnimatedCloth>();
        animCloth.ChangeCloth(cloth);
    }

}
