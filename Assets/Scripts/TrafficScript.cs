using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficScript : MonoBehaviour
{
    public float health;
    public float speed;

    GameObject player;

    public float damageTickTime = 0;
    public float damageTickLimit;

    public bool colliding = false;


    // Start is called before the first frame update

    //Sets up random initial health for the cop car.
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = 5;
    }

    // Update is called once per frame; Makes the object move towards the camera, deletes object if it goes past the camera or if cop car runs out of health
    void Update()
    {
        if (!colliding)
        {
            transform.position -= new Vector3(0, 0, speed);
        }


        if (colliding)
        {
            damageTickTime += Time.deltaTime;

            if (damageTickTime > damageTickLimit)
            {
                damageTickTime = 0;
                health--;
                player.GetComponent<PlayerDamage>().loseMoney();
            }
        }


        if(transform.position.z <= -14 || health <= 0)
        {
            Destroy(this.gameObject);
        }
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
