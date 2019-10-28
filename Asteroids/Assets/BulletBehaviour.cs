using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5.0f);
    }
    
    void Update()
    {
        rb.velocity = transform.forward * bulletSpeed;
    }
}
