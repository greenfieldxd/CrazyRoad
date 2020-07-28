using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;


    private void OnTriggerEnter(Collider other)
    {
        //audio.PlayOneShot(coinSound);
        GameManager.Instance.AddCoin();
        Destroy(gameObject);
    }
    
}
