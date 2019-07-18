using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameController GC;
    public int laneNum;

    void FixedUpdate()
    {
        if (!GC.isGameOver)
        {
            if (Input.GetKey(KeyCode.A) && laneNum > 0){

            }
        }
    }
}
