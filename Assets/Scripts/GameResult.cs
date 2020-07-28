using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResult : MonoBehaviour
{
    [SerializeField] Text resultText;
    [SerializeField] Text bestScoreText;
    [SerializeField] Text allCoinsText;

    [SerializeField] Button onButton;
    [SerializeField] Button offButton;


    // Start is called before the first frame update
    void Start()
    {
       //Canvas canvas = GameManager.Instance.GetComponentInChildren<Canvas>();//enable false game Canvas
       //canvas.enabled = false;

       //int newScore = GameManager.Instance.score;
       //int bestScore = PlayerPrefs.GetInt("BestScore", 0); //get bestScore

       //int newCoins = GameManager.Instance.coins;
       //int allCoins = PlayerPrefs.GetInt("Coins", 0); //get coins

       //PlayerPrefs.SetInt("Coins", allCoins + newCoins);

       //if (newScore > bestScore)
       //{
       //    PlayerPrefs.SetInt("BestScore", newScore);
       //}


       //resultText.text = "Score is: " + newScore;
       //bestScoreText.text = "Best score is: " + bestScore;
       //allCoinsText.text = "" + allCoins;
        
    }

   

}
