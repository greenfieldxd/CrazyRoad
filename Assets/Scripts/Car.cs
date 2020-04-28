using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] AudioClip carSound;

    private void OnTriggerEnter(Collider other)
    {
        Player player = FindObjectOfType<Player>();
        AudioSource audio = player.GetComponent<AudioSource>();
        SceneLoader sceneLoder = FindObjectOfType<SceneLoader>();

        audio.PlayOneShot(carSound);
        sceneLoder.LoadEndScene();
    }

}
