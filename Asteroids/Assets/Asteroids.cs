using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    private List<Transform> asteroids = new List<Transform>();
    public GameObject prefab;
    public int asteroidNumbers = 3;
    public float spawnRange = 30;
    
    void Start()
    {
        for (int i = 0; i < asteroidNumbers; i++) {
            SpawnAsteroid();
        }
    }

    public void SpawnAsteroid() {
        GameObject go = Instantiate(prefab, randomSpawnPosition(), Quaternion.identity, this.transform);
        asteroids.Add(go.transform);
    }

    private Vector3 randomSpawnPosition() {
        float x;
        float z;

        do {
            x = Random.Range(-spawnRange, spawnRange);
            z = Random.Range(-spawnRange, spawnRange);
        } while (x > -5 && x < 5 && z > -5 && z < 5);

        return new Vector3(x, 1, z);
    }
}
