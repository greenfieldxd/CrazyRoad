using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int score { get; private set; }
    [HideInInspector] public int coins { get; private set; }

    [SerializeField] GameObject startPlayerPos;
    [SerializeField] Text textScore;
    [SerializeField] Text textCoin;

    [SerializeField]Player player;

    float gameDistance = 0;





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
        score = 0;
        coins = 0;
        textScore.text = "Score: " + score;
        textCoin.text = "0";

        UpdateSounds();

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

    void UpdateSounds()
    {
        int soundParam = PlayerPrefs.GetInt("Music", 1);

        if (soundParam == 0)
        {
            AudioSource music = GetComponentInChildren<AudioSource>();
            music.enabled = false;
        }
        else if(soundParam == 1)
        {
            AudioSource music = GetComponentInChildren<AudioSource>();
            music.enabled = true;
        }
    }
    

}
