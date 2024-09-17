using UnityEngine;

public class RespawnOnTrigger : MonoBehaviour
{
    private Vector3 PositionStart;
    public string respawnTag = "Respawn";  

    void Start()
    {
        PositionStart= transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(respawnTag))
        {
            Respawn();
        }
    }
    private void Respawn()
    {
        transform.position = PositionStart;
    }
}
