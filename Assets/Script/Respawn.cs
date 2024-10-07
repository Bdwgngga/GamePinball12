using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnTrigger : MonoBehaviour
{
    private Vector3 PositionStart;
    public string respawnTag = "Respawn";
    [SerializeField] GameObject GameOver;

    void Start()
    {
        PositionStart= transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
       
            GameOver.SetActive(true);
            Time.timeScale = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }

    public void Retry()
    {
        GameOver.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void Respawn()
    {
        transform.position = PositionStart;
    }
}
