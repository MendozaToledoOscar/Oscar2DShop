using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{
    public Text coinsText;

    public void UpdateCoinsText(int value)
    {
        coinsText.text = "x " + value.ToString();
    }
}
