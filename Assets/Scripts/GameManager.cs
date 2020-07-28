using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public int score { get; private set; }
    public int coins { get; private set; }
    
    [SerializeField] Text textScore;
    [SerializeField] Text textCoin;
    
    private int gameDistance = 0;
    private GameObject startPlayerPos;

    private const string MUSIC_KEY = "MUSIC_KEY_NO_OR_OFF";
=======
    public int score;
    public int coins;

    public GameObject startPlayerPos;
    public Text textScore;
    public Text textCoin;

    float gameDistance = 0;
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

    Player player;



    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

    }

    private void Start()
    {
<<<<<<< HEAD
=======
        player = FindObjectOfType<Player>();
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

        score = 0;
        coins = 0;


        DontDestroyOnLoad(gameObject);

    }

    public void AddScore(int score) // Add value to Score

    {
        float currentPosition = Vector3.Distance(Player.Instance.transform.position, startPlayerPos.transform.position);

        if (gameDistance < currentPosition)
        {
            gameDistance = (int) currentPosition;

            this.score += score;
            //textScore.text = "Score: " + this.score; // update Score on scene
        }

    }


    public void AddCoin()
    {
        coins ++;
    }

   

  
    

}
