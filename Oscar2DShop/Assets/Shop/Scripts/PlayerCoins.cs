using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int numberOfCoins;
    public CoinsUI coinsUI;

    private void Start()
    {
        coinsUI.UpdateCoinsText(numberOfCoins);
    }

    public void UpdateCoins(int differnce)
    {
        numberOfCoins += differnce;
        coinsUI.UpdateCoinsText(numberOfCoins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            UpdateCoins(100);
        }
    }
}
