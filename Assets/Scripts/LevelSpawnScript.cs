using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnScript : MonoBehaviour
{
    public GameObject trafficPrefab;
    private GameObject trafficClone;

    public float spawnTime;
    private bool canSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (Obstacles and Passengers can spawn at -1.5, -0.5, 0,5 or 1,5 for x and  due to size of road; z pos of spawn is 80 and y pos is  1.8)
    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime > 2)
        {
            float xPos = 0.5f;
            int rand = Random.Range(1, 5);

            if(rand == 1)
            {
                xPos = -1.5f;
            }
            else 
            if(rand == 2)
            {
                xPos = -0.5f; 
            }
            else
                if(rand == 4)
            {
                xPos = 1.5f;
            }

            trafficClone = Instantiate(trafficPrefab, new Vector3(xPos, 1.88f, 80), trafficPrefab.transform.rotation);
            spawnTime = 0;
        }
    }
}
