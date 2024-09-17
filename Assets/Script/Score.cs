using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    TextMeshProUGUI skortext;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        skortext = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void tambahscore()
    {
        Debug.Log("Skor Bertambah");
        score = score + 5;
        skortext.text = "Score: " + score;
    }

    public void BackMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }

}
