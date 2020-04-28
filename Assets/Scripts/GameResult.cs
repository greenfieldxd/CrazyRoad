﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResult : MonoBehaviour
{
    [SerializeField] Text resultText;
    [SerializeField] Text bestScoreText;
    [SerializeField] Text allCoinsText;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();

        Canvas canvas = gm.GetComponentInChildren<Canvas>();//enable false game Canvas
        canvas.enabled = false;

        int newScore = gm.score;
        int bestScore = PlayerPrefs.GetInt("BestScore", 0); //get bestScore

        int newCoins = gm.coins;
        int allCoins = PlayerPrefs.GetInt("Coins", 0); //get coins

        PlayerPrefs.SetInt("Coins", allCoins + newCoins);

        if (newScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", newScore);
        }


        resultText.text = "Score is: " + newScore;
        bestScoreText.text = "Best score is: " + bestScore;
        allCoinsText.text = "" + allCoins;

    }

    public void SoundOn()
    {
        PlayerPrefs.SetInt("Music", 1);

        AudioSource music = gm.GetComponentInChildren<AudioSource>();
        music.enabled = true;
    }
    public void SoundOff()
    {
        PlayerPrefs.SetInt("Music", 0);

        AudioSource music = gm.GetComponentInChildren<AudioSource>();
        music.enabled = false;
    }



}
