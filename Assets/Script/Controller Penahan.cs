using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPenahan : MonoBehaviour
{
    public KeyCode input;

    private HingeJoint hj;

    void Start()
    {
        hj = GetComponent<HingeJoint>();
    }

    void Update()
    {
        Inputan();
    }

    private void Inputan()
    {
        JointSpring jointSpring = hj.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring = 1000; // Mengatur kekuatan pegas
        }
        else
        {
            jointSpring.spring = 0; // Mengatur kekuatan pegas ke 0 saat tombol tidak ditekan
        }

        hj.spring = jointSpring; 
    }
}
