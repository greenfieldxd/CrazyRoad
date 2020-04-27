using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour
{
    [Header("in percent %")]
    [SerializeField] float chance;

    [SerializeField] GameObject[] trees;
    [SerializeField] GameObject coin;

   


    // Start is called before the first frame update
    void Start()
    {
        CreateTrees();
        CreateCoin();
    }




    private void CreateTrees()
    {
        foreach (GameObject tree in trees)
        {
            int randomX;
            randomX = Random.Range(-18, 19);
            Vector3 newPosition = new Vector3(randomX, 1, transform.position.z);
            Lean.Pool.LeanPool.Spawn(tree, newPosition, Quaternion.identity);
        }
    }

    void CreateCoin()
    {
        float randomValue = Random.value;
        if (randomValue < chance)
        {
            int randomX;
            randomX = Random.Range(-18, 19);
            Vector3 newPosition = new Vector3(randomX, 1, transform.position.z);


            Lean.Pool.LeanPool.Spawn(coin, newPosition, coin.transform.rotation);

        }
    }
}
