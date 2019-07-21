using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameController GC;
    public int laneNum = 2;
    public int custNum = 0;
    public Text custText;
    public Text gameOverText;
    

    void Update()
    {
        ///restart
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
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
        if(custNum < 0)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Customer")
        {
            Debug.Log("Picked up customer");
            custNum++;
            Debug.Log("Customers: " + custNum);
            Sound.Instance.PlayOneShot(Sound.Instance.hailing);
        }

        if(other.collider.tag == "Car")
        {
            Debug.Log("Hit a car");
            custNum--;
            Debug.Log("Customers: " + custNum);
            Sound.Instance.PlayOneShot(Sound.Instance.crash);
        }
        custText.text = "Customers: "+custNum.ToString();
    }
}
