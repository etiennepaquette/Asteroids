using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    public int Size = 3;
    public bool FirstWave = true;

    void Start()
    {
        this.transform.localScale = Vector3.one * Size;
        var rb = this.GetComponent<Rigidbody>();
        this.transform.rotation = randomDirection();
        rb.velocity = transform.forward * 2f;
    }

    private Quaternion randomDirection() {
        if (FirstWave) {
            var angleY = Random.Range(-20, 20);
            Vector3 relativePos = ShipMovements.Ship.transform.position - this.transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);

            return rotation *= Quaternion.Euler(0, angleY, 0);
        } else {
            return Quaternion.Euler(0, Random.Range(0,360), 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") {
            Destroy(other.gameObject);
            Size--;
            if (Size > 0) {
                for (int i = 0; i < Random.Range(2,4); i++) {
                    var goScript = Instantiate(this.gameObject).GetComponent<AsteroidBehaviour>();
                    goScript.Size = Size;
                    goScript.FirstWave = false;
                }
            }
            Destroy(this.gameObject);
        }
    }

}
