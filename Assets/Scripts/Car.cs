using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] AudioClip carSound;

    private void OnTriggerEnter(Collider other)
    {
        //audio.PlayOneShot(carSound);
        SceneLoader.Instance.LoadEndScene();
    }

}
