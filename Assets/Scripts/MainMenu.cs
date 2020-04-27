using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        int allCoins = PlayerPrefs.GetInt("Coins", 0);
        coinsText.text = "" + allCoins;
    }

    
}
