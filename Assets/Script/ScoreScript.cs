using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
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
        score = score + 15;
        skortext.text = "Score : " + score;
    }
}