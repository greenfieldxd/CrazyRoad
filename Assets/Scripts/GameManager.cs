using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startPlayerPos;
    public Text textScore;
    public Text textCoin;

    int score;
    int coins;
    float gameDistance = 0;

    SceneLoader sceneLoader;
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
        sceneLoader = FindObjectOfType<SceneLoader>(); //Find SceneLoader on scene
        player = FindObjectOfType<Player>();

        score = 0;
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


    

}
