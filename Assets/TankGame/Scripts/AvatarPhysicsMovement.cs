using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPhysicsMovement : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float acceleration;
    [SerializeField] float jumpVelocity;

    [SerializeField] Damagable damagabe;
    [SerializeField] AvatarInput input;
    [SerializeField] Rigidbody rgbd;

    [SerializeField] Animator anim;

    void OnValidate()
    {
        if (damagabe == null)
            damagabe = GetComponentInChildren<Damagable>();
        if (input == null)
            input = GetComponentInChildren<AvatarInput>();
        if (rgbd == null)
            rgbd = GetComponentInChildren<Rigidbody>();
        if (anim == null)
            anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (damagabe.health > 0)
        {
            TryJump();
        } 
    }

    void TryJump()
    {
        if (input.IsJumping())
            rgbd.AddForce(Vector3.up * jumpVelocity, ForceMode.VelocityChange);
    }

    void FixedUpdate()
    {
        if (damagabe.health > 0)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 inputVector = input.InputVector();
        // rgbd.velocity = inputVector.normalized * speed;

        anim.SetBool("Is Running", inputVector != Vector3.zero);
        rgbd.AddForce(inputVector * acceleration, ForceMode.Acceleration);

        Vector3 vel = rgbd.velocity;
        Vector3 velHorizontal = new Vector3(vel.x, 0, vel.z);
        float currentHorizontalSpeed = velHorizontal.magnitude;

        // Version 1
        // if (currentSpeed > maxSpeed)
        //      rgbd.velocity = vel.normalized * maxSpeed;

        // Version 2
        // if (currentSpeed > maxSpeed)
        //      rgbd.velocity *= maxSpeed / currentSpeed;

        // Versoin 3
        if (currentHorizontalSpeed > maxSpeed) 
        {        
            Vector3 clamped = Vector3.ClampMagnitude(velHorizontal, maxSpeed);
            clamped.y = vel.y;
            rgbd.velocity = clamped;
        }

    }
}
