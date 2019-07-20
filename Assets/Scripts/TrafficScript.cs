using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficScript : MonoBehaviour
{
    public float speed;

    GameObject player;

    public bool colliding = false;


    // Start is called before the first frame update

    //Sets up random initial health for the cop car.
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame; Makes the object move towards the camera, deletes object if it goes past the camera or if cop car runs out of health
    void Update()
    {

            transform.position -= new Vector3(0, 0, speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            colliding = true;
        }
        else {
            colliding = false;
        }
    }
}
