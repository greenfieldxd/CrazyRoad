using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using DG.Tweening;

public class RoadScript : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] float chance;
    [SerializeField] float startTimeDelayRandom;
    [SerializeField] float carRate;

    float randomX;

    Vector3 newPosition;


    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.value;
        if (randomX >= chance)
        {
            randomX = 20;
            newPosition = new Vector3(randomX, 0, transform.position.z);
        }
        else
        {
            randomX = -20;
            newPosition = new Vector3(randomX, 0, transform.position.z);
        }

        float randomStartTime = Random.Range(1, startTimeDelayRandom);
        StartCoroutine(CreateCars(randomStartTime));
    }



    IEnumerator CreateCars(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            GameObject newCar = LeanPool.Spawn(car, newPosition, car.transform.rotation);
            if (randomX == -20)
            {
                newCar.transform.DOMoveX(40, 20, false).OnComplete(()=> LeanPool.Despawn(newCar));

            }
            else
            {
                newCar.transform.DOMoveX(-40, 20, false).OnComplete(()=> LeanPool.Despawn(newCar));

            }
        }

    }


}
