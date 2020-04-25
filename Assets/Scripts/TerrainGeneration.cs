using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{

    
    [SerializeField] int maxTerrainCount;
    [SerializeField] List<TerrainData> terrainsDatas = new List<TerrainData>();
    [SerializeField] Transform terrainHolder;

    List<GameObject> currentTerrains = new List<GameObject>();
    [HideInInspector] public Vector3 currentPosition = new Vector3(0, 0, 0);


    private void Start()
    {
        for (int i = 0; i < maxTerrainCount; i++)
        {
            SpawnTerrain(true);
        }
        maxTerrainCount = currentTerrains.Count;
    }




    public void SpawnTerrain(bool isStart)
    {

        int whichTerrain = Random.Range(0, terrainsDatas.Count);
        int terrainSuccession = Random.Range(1, terrainsDatas[whichTerrain].maxInSuccession);
        for (int i = 0; i < terrainSuccession; i++)
        {
            GameObject terrain = Instantiate(terrainsDatas[whichTerrain].terrain, currentPosition, Quaternion.identity, terrainHolder);
            currentTerrains.Add(terrain);
            
            currentPosition.z++;
        }



    }



}
