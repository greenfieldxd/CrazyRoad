using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public int coins;

    public GameObject startPlayerPos;
    public Text textScore;
    public Text textCoin;

    float gameDistance = 0;

    Player player;




    private void Awake() //Fix more gamemanagers
    {
        GameManager[] gameManagers = FindObjectsOfType<GameManager>();
        if (gameManagers.Length > 1)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        player = FindObjectOfType<Player>();

        score = 0;
        coins = 0;
        textScore.text = "Score: " + score;
        textCoin.text = "0";

        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score) // Add value to Score

    {
        float currentPosition = Vector3.Distance(player.transform.position, startPlayerPos.transform.position);

        if (gameDistance < currentPosition)
        {
            gameDistance = currentPosition;

            this.score += score;
            textScore.text = "Score: " + this.score; // update Score on scene
        }

    }


    public void AddCoin()
    {
        coins += 1;
        textCoin.text = " " + coins; // update Coins on scene
    }

    public void NewGame()
    {
        player = FindObjectOfType<Player>();

        gameDistance = 0;
        score = 0;
        coins = 0;
        textScore.text = "Score: " + score;
        textCoin.text = "0";

        Canvas canvas = GetComponentInChildren<Canvas>();
        canvas.enabled = true;
    }
    

}
