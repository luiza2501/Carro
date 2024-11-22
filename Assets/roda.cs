using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roda : MonoBehaviour
{
    private WheelJoint2D wheel;
    private JointMotor2D motor;

    public float speed;
    void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor;
    }
    void Update()
    {
        
        float hForce = Input.GetAxis("Horizontal");

        motor.motorSpeed = speed * hForce;

        wheel.motor = motor;
    }
}