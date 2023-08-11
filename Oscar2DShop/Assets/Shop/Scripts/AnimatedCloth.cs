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

    public void ChangeCloth(PlayerCloth newCloth)
    {
        idle.sprite = newCloth.Idle;
        idle.color = newCloth.clothColor;
        for (int i = 0; i < up.Count; i++)
        {
            up[i].sprite = newCloth.Up[i];
            down[i].sprite = newCloth.Down[i];
            left[i].sprite = newCloth.Left[i];
            right[i].sprite = newCloth.Right[i];

            up[i].color = newCloth.clothColor;
            down[i].color = newCloth.clothColor;
            left[i].color = newCloth.clothColor;
            right[i].color = newCloth.clothColor;
        }
    }

    private void Start()
    {
        ChangeCloth(cloth);
    }
}
