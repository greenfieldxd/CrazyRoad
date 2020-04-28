using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lean.Touch;

public class Player : MonoBehaviour
{
    public float moveDelay = 0.8f;
    public int stepPoint;

    float endPos;

    Animator anim;
    Rigidbody rb;

    TerrainGeneration terrainGeneration;
    GameManager gm;
    AudioSource audio;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();


        terrainGeneration = FindObjectOfType<TerrainGeneration>();
        gm = FindObjectOfType<GameManager>();
        
        gm.NewGame();
    }

    public void MoveWithTap()
    {
        endPos = transform.position.z + 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();

        
        terrainGeneration.SpawnTerrain();
        gm.AddScore(stepPoint);
    }

    public void Up()
    {
        endPos = transform.position.z + 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();



        terrainGeneration.SpawnTerrain();
        gm.AddScore(stepPoint);
    }

    public void Down()
    {
        endPos = transform.position.z - 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();

    }

    public void Right()
    {
        endPos = transform.position.x + 1;

        rb.DOMoveX(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();

    }

    public void Left()
    {
        endPos = transform.position.x - 1;

        rb.DOMoveX(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();

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
            Up();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Down();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left();
        }

       

        

    }







}
