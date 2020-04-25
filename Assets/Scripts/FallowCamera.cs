using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    public GameObject player;

    public float delay = 3.5f;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, (player.transform.position + offset), delay * Time.deltaTime);
    }
}
