using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public int stepPoint;
    [SerializeField] float moveTime = 0.8f;
    [SerializeField] float jumpForce = 0.6f;

    [SerializeField] TerrainGeneration terrainGeneration;
    [SerializeField] GameManager gm;
    [SerializeField] AudioSource audioSource;

    bool input;

    private void Start()
    {
        gm.NewGame();
        input = true;
    }

    void Update()
    {
        if (!input)
        {
            return;
        }

        KeyBoardInput();

    }

    public void MoveWithTap()
    {
        Vector3 endPos = transform.position + Vector3.forward;

        MovePlayer(endPos);
        audioSource.Play();

        terrainGeneration.SpawnTerrain();
        gm.AddScore(stepPoint);
    }


    public void Up()
    {
        Vector3 endPos = transform.position + Vector3.forward;

        MovePlayer(endPos);
        audioSource.Play();

        terrainGeneration.SpawnTerrain();
        gm.AddScore(stepPoint);
    }

    public void Down()
    {
        Vector3 endPos = transform.position + Vector3.back;

        MovePlayer(endPos);

        audioSource.Play();

    }

    public void Right()
    {
        Vector3 endPos = transform.position + Vector3.right;

        MovePlayer(endPos);
        
        audioSource.Play();

    }

    public void Left()
    {
        Vector3 endPos = transform.position + Vector3.left;

        MovePlayer(endPos);
        
        GetComponent<AudioSource>().Play();

    }


    void MovePlayer(Vector3 endPos)
    {
        input = false;
        transform.DOJump(endPos, jumpForce, 1, moveTime).OnComplete(ResetInput);

    }

    void ResetInput()
    {
        input = true;
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
