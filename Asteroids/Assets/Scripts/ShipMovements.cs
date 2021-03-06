﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovements : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 200f;
    private Rigidbody rb;

    public static GameObject Ship;
    
    void Start()
    {
        Ship = this.gameObject;
        rb = this.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        
        rb.AddForce(transform.forward * verticalMovement * speed);
        rb.rotation *= Quaternion.AngleAxis(turnSpeed * horizontalMovement * Time.deltaTime, Vector3.up);
    }
}
