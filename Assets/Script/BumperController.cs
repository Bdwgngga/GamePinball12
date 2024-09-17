using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float speed;
    public Animator animator;
    public ScoreScript Score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= speed;
            animator.SetBool("Hit", true);
        }
        else
        {
            animator.SetBool("Hit", false);
        }
    }
}