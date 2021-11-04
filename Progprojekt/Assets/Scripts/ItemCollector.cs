using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coin_count = 0;

    [SerializeField] Text coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin_count++;
            coinsText.text = "Coins: " + coin_count;
        }
    }
}
