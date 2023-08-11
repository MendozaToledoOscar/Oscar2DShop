using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedCloth : MonoBehaviour
{
    public PlayerCloth cloth;

    public SpriteRenderer idle;
    public List<SpriteRenderer> up = new List<SpriteRenderer>();
    public List<SpriteRenderer> down = new List<SpriteRenderer>();
    public List<SpriteRenderer> left = new List<SpriteRenderer>();
    public List<SpriteRenderer> right = new List<SpriteRenderer>();

    public void ChangeCloth()
    {
        idle.sprite = cloth.Idle;
        idle.color = cloth.clothColor;
        for (int i = 0; i < up.Count; i++)
        {
            up[i].sprite = cloth.Up[i];
            down[i].sprite = cloth.Down[i];
            left[i].sprite = cloth.Left[i];
            right[i].sprite = cloth.Right[i];

            up[i].color = cloth.clothColor;
            down[i].color = cloth.clothColor;
            left[i].color = cloth.clothColor;
            right[i].color = cloth.clothColor;
        }
    }

    private void Start()
    {
        ChangeCloth();
    }
}
