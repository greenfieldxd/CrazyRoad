using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lean.Touch;
<<<<<<< HEAD
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float moveTime = 0.5f;
    [SerializeField] float jumpPower = 1f;
    [SerializeField] float reloadLevelDelay = 1f;

    [Header("FX")]
    [SerializeField] GameObject particleFXDeath;

    [Header("Sounds")]
    [SerializeField] AudioClip deathSound;
    
    private TerrainGeneration terrainGeneration;
    
    float endPos;
    bool allowInput;
    
    public static Player Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

    }
    
  
    
    private void Start()
    {
        terrainGeneration = FindObjectOfType<TerrainGeneration>();
        
        //GameManager.Instance.NewGame();
        allowInput = true;
    }
    
    public void Die()
    {
        Destroy(gameObject);
        Instantiate(particleFXDeath, transform.position, Quaternion.identity);
        //AudioManager.Instance.PlaySound(deathSound);

        SceneLoader.Instance.RestartScene();
=======

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
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump
    }

    public void MoveWithTap()
    {
<<<<<<< HEAD
        if (!allowInput) { return; }

        Vector3 newPosition = transform.position + Vector3.forward; // new Vector (0, 0, 1)
        MoveTo(newPosition, Vector3.forward);
=======
        endPos = transform.position.z + 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();

>>>>>>> parent of e6eb1d1... Fix snapping, change Jump
        
        terrainGeneration.SpawnTerrain();
    }

<<<<<<< HEAD


  
=======
    public void Up()
    {
        endPos = transform.position.z + 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();


>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (!allowInput)
        {
            //Exit
            return;
        }
=======
        endPos = transform.position.z - 1;

        rb.DOMoveZ(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveForward();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveBack();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
    }

    public void MoveLeft()
    {
<<<<<<< HEAD
        if (!allowInput)  { return; }
=======
        endPos = transform.position.x + 1;

        rb.DOMoveX(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

        Vector3 newPosition = transform.position + Vector3.left;
        MoveTo(newPosition, Vector3.left);
    }

    public void MoveRight()
    {
<<<<<<< HEAD
        if (!allowInput) { return; }
=======
        endPos = transform.position.x - 1;

        rb.DOMoveX(endPos, moveDelay, false);
        anim.SetTrigger("Jump");
        audio.Play();
>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

        Vector3 newPosition = transform.position + Vector3.right;
        MoveTo(newPosition, Vector3.right);
    }

<<<<<<< HEAD
    public void MoveBack()
    {
        if (!allowInput) { return; }

        Vector3 newPosition = transform.position + Vector3.back;
        MoveTo(newPosition, Vector3.back);
    }

    public void MoveForward()
    {
        if (!allowInput) { return; }
=======
    // Update is called once per frame
    void Update()
    {
        KeyBoardInput();

    }

>>>>>>> parent of e6eb1d1... Fix snapping, change Jump

        Vector3 newPosition = transform.position + Vector3.forward; // new Vector (0, 0, 1)
        MoveTo(newPosition, Vector3.forward);
        terrainGeneration.SpawnTerrain();
    }
    
    void MoveTo(Vector3 newPosition, Vector3 direction)
    {
        RaycastHit hit;
        
        Debug.DrawRay(newPosition, Vector3.down, Color.green, 2f);

        var hitObject = Physics.Raycast(transform.position, direction, out hit, 1f);
        
        if (hitObject && hit.collider.CompareTag("Coin"))
        {
            allowInput = false;
            transform.DOJump(newPosition, jumpPower, 1, moveTime).OnComplete(ResetInput);
        }
        if (!hitObject)
        {
            allowInput = false;
            transform.DOJump(newPosition, jumpPower, 1, moveTime).OnComplete(ResetInput);
        }

<<<<<<< HEAD
    }
    
    void ResetInput()
    {
        allowInput = true;
=======
       

        

>>>>>>> parent of e6eb1d1... Fix snapping, change Jump
    }







}
