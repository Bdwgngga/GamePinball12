using System.Collections;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;
    private bool bolaInside = false;
    public float maxTimeHold;
    public float maxForce;

    private bool isHold = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            bolaInside = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider == bola)
        {
            bolaInside = false;
        }
    }
    private void Update()
    {
        if (bolaInside && Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(bola));
            Debug.Log("LAUNCHER DITEKAN");
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}

