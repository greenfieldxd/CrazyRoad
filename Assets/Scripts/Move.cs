using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    public float moveDelay = 0.8f;
        
    float endPos;
    Animator anim;
    TerrainGeneration terrainGeneration;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        terrainGeneration = FindObjectOfType<TerrainGeneration>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            endPos = transform.position.z + 1;

            transform.DOMoveZ(endPos, moveDelay, false);
            anim.SetTrigger("Jump");

            terrainGeneration.SpawnTerrain(false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            endPos = transform.position.z - 1;

            transform.DOMoveZ(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            endPos = transform.position.x + 1;

            transform.DOMoveX(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            endPos = transform.position.x - 1;

            transform.DOMoveX(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }



    }
    




}
