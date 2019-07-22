using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    
    public void BeginGame()
    {

        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()

    {
        Debug.Log("QUIT");
        Application.Quit();

    }

}
