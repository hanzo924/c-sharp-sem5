using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    int score = 0;
    [SerializeField] private Text coinText;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            score++;
            Debug.Log(score);
            Destroy(collider.gameObject);
            coinText.text = "Coins: " + score;
        }
    }
}
