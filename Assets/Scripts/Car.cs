using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SceneLoader sceneLoder = FindObjectOfType<SceneLoader>();
        sceneLoder.LoadEndScene();
    }

}
