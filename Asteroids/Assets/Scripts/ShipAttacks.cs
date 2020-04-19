using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttacks : MonoBehaviour
{
    public Transform bulletOrigin;
    public GameObject prefBullet;
    public float fireDelay = 0.5f;
    public float lastFireTimestamp = 0.0f;
    public Transform bulletsParent;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && (Time.time - lastFireTimestamp) > fireDelay) {
            Instantiate(prefBullet, bulletOrigin.position, bulletOrigin.rotation, bulletsParent);
            lastFireTimestamp = Time.time;
        }
    }
}
