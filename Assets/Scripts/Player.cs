using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public float moveDelay = 0.8f;
    public int stepPoint;
        
    float endPos;

    Animator anim;
    Rigidbody rb;

    TerrainGeneration terrainGeneration;
    GameManager gm;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();

        terrainGeneration = FindObjectOfType<TerrainGeneration>();
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyBoardInput();

    }

    private void KeyBoardInput() //KeyBoard Move
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            endPos = transform.position.z + 1;

            rb.DOMoveZ(endPos, moveDelay, false);
            anim.SetTrigger("Jump");

            terrainGeneration.SpawnTerrain();
            gm.AddScore(stepPoint);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            endPos = transform.position.z - 1;

            rb.DOMoveZ(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            endPos = transform.position.x + 1;

            rb.DOMoveX(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            endPos = transform.position.x - 1;

            rb.DOMoveX(endPos, moveDelay, false);
            anim.SetTrigger("Jump");
        }
    }


    




}
