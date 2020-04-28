using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;


    private void OnTriggerEnter(Collider other)
    {
         GameManager gm = FindObjectOfType<GameManager>();

        Player player = FindObjectOfType<Player>();
        AudioSource audio = player.GetComponent<AudioSource>();

        audio.PlayOneShot(coinSound);
        gm.AddCoin();
        Destroy(gameObject);
    }
    
}
