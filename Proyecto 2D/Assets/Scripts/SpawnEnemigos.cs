using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject[] enemigos;

    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform xRangeUp;
    public Transform xRangeDown;

    public float timeSpawn = 1;
    public float repeatSpawnRate = 3;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", timeSpawn, repeatSpawnRate);
    }

    public void SpawnEnemies()
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);

        spawnposition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(xRangeDown.position.y, xRangeUp.position.y),0);

        GameObject enemy = Instantiate(enemigos[Random.Range(0, enemigos.Length)], spawnposition, gameObject.transform.rotation);

    }

}
