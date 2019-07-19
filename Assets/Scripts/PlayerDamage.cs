using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float money = 300;
    public GameController GC;

    // Start is called before the first frame update
    void Start()
    {
        print(money);
    }

    // Update is called once per frame
    void Update()
    {

        if (money <= 0)
        {
            print("Player Lost");
            GC.isGameOver = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collided");

        /*if (collision.gameObject.tag == "Car") {
            money -= 50;
            print(money);
        }*/
    }

    public void loseMoney()
    {
        money -= 20;
        print(money);
    }
}
