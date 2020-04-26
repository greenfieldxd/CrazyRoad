using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour
{
    [Header("in percent %")]
    public float chance;

    public GameObject[] trees;
    public GameObject coin;


    // Start is called before the first frame update
    void Start()
    {
        CreateTrees();
        CreateCoin();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private void CreateTrees()
    {
        foreach (GameObject tree in trees)
        {
            int randomX;
            randomX = Random.Range(-18, 19);
            Vector3 newPosition = new Vector3(randomX, 1, transform.position.z);
            Instantiate(tree, newPosition, Quaternion.identity);
        }
    }

    void CreateCoin()
    {
        float randomValue = Random.value;
        Debug.Log(randomValue);
        if (randomValue < chance)
        {
            int randomX;
            randomX = Random.Range(-18, 19);
            Vector3 newPosition = new Vector3(randomX, 1, transform.position.z);


            Instantiate(coin, newPosition, coin.transform.rotation);
        }
    }
}
