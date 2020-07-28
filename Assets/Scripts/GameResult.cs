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

<<<<<<< HEAD
       //PlayerPrefs.SetInt("Coins", allCoins + newCoins);
=======
        int newCoins = gm.coins;
        int allCoins = PlayerPrefs.GetInt("Coins", 0); //get coins
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

       //if (newScore > bestScore)
       //{
       //    PlayerPrefs.SetInt("BestScore", newScore);
       //}

<<<<<<< HEAD
=======
        if (newScore > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", newScore);
        }


        resultText.text = "Score is: " + newScore;
        bestScoreText.text = "Best score is: " + bestScore;
        allCoinsText.text = "" + allCoins;

        UpdateBattons();
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

       //resultText.text = "Score is: " + newScore;
       //bestScoreText.text = "Best score is: " + bestScore;
       //allCoinsText.text = "" + allCoins;
        
    }

<<<<<<< HEAD
   
=======
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

    void UpdateBattons()
    {
        int soundParam = PlayerPrefs.GetInt("Music", 1);

        if (soundParam == 0)
        {
            offButton.gameObject.SetActive(false);
            onButton.gameObject.SetActive(true);
        }
        else if (soundParam == 1)
        {
            offButton.gameObject.SetActive(true);
            onButton.gameObject.SetActive(false);
        }
    }
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

}
