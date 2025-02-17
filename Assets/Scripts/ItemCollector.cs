﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;

    [SerializeField] private Text coinsText;
    [SerializeField] private AudioSource coinSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins; 
        }
    }
}