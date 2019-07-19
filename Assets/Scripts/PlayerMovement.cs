using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameController GC;
    public int laneNum = 2;

    void FixedUpdate()
    {
        if (true)
        {
            if (Input.GetKeyDown(KeyCode.A) && laneNum > 1)
            {
                gameObject.transform.position -= new Vector3(1, 0, 0);
                laneNum--;

            }
            if (Input.GetKeyDown(KeyCode.D) && laneNum < 4)
            {
                gameObject.transform.position += new Vector3(1, 0, 0);
                laneNum++;

            }
        }
    }
}
