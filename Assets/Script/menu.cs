using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("pinball");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }


    public void Credits()
    {
        SceneManager.LoadScene("credit");
    }
}

