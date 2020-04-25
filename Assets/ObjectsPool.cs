using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool : MonoBehaviour
{
    Transform poolTransform;

    int idElement;

    public int poolCount;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //poolTransform.position = transform.position + new Vector3(20, 0, 0);

       // for (int i = 0; i < poolCount; i++)
       // {
        //    Instantiate(prefab, poolTransform.position, transform.rotation);
       // }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
