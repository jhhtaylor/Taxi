using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficScript : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame; Makes the object move towards the camera, deletes object if it goes past the camera
    void Update()
    {
        transform.position -= new Vector3(0,0,speed);

        if(transform.position.z <= -14)
        {
            Destroy(this.gameObject);
        }
    }
}
