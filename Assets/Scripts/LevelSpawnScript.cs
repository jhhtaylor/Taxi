using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnScript : MonoBehaviour
{
    public GameObject trafficPrefab;
    public GameObject customerPrefab;
    private GameObject trafficClone;
    private GameObject customerClone;

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
            int rand = Random.Range(1, 9);

            if (rand == 1 || rand == 5)
            {
                xPos = -1.5f;
            }
            else
            if (rand == 2 || rand == 6)
            {
                xPos = -0.5f;
            }
            else if (rand == 3 || rand == 7)
            {
                xPos = 0.5f;
            }
            else
            if (rand == 4 || rand == 8)
            {
                xPos = 1.5f;
            }
            if (rand == 1 || rand == 2 || rand == 3 || rand == 4)
            {
                trafficClone = Instantiate(trafficPrefab, new Vector3(xPos, 1.55f, 80), trafficPrefab.transform.rotation);
            }
            if (rand == 5 || rand == 6 || rand == 7 || rand == 8)
            {
                customerClone = Instantiate(customerPrefab, new Vector3(xPos, 1.88f, 80), customerPrefab.transform.rotation);
            }

            spawnTime = 0;
        }
    }
}
