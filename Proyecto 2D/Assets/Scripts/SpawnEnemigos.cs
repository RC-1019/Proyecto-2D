using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    [Header("Datos enemigos")]
    public GameObject[] enemigos;
    public float enemyTimeSpawn = 1;
    public float enemyRepeatSpawnRate = 3;

    [Header("Datos aliados")]
    public GameObject[] aliados;
    public float allyTimeSpawn = 1;
    public float allyRepeatSpawnRate = 3;

    [Header("Datos Spawn")]
    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform xRangeUp;
    public Transform xRangeDown;
    

    public float difficultyTime;


    private void Start()
    {
        StartCoroutine("EnemyDifficulty");
        StartCoroutine("AllySpawnRate");
    }

    private void Update()
    {
        difficultyTime += Time.deltaTime;

        if(difficultyTime > 10 && difficultyTime < 25)
        {
            enemyRepeatSpawnRate = 2;
            allyRepeatSpawnRate = 3.5f;
        }

        if (difficultyTime > 25 && difficultyTime < 40)
        {
            enemyRepeatSpawnRate = 1;
            allyRepeatSpawnRate = 3.7f;
        }

        if (difficultyTime > 40 && difficultyTime < 60)
        {
            enemyRepeatSpawnRate = 0.75f;
            allyRepeatSpawnRate = 4;
        }
        if (difficultyTime > 60)
        {
            enemyRepeatSpawnRate = 0.50f;
            allyRepeatSpawnRate = 4.2f;
        }
    }

    IEnumerator EnemyDifficulty()
    {
        yield return new WaitForSeconds(enemyRepeatSpawnRate);
        SpawnEnemies();
        StartCoroutine("EnemyDifficulty");
    }

    IEnumerator AllySpawnRate()
    {
        yield return new WaitForSeconds(allyRepeatSpawnRate);
        SpawnAlly();
        StartCoroutine("AllySpawnRate");
    }

    public void SpawnEnemies()
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);

        spawnposition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(xRangeDown.position.y, xRangeUp.position.y),0);

        GameObject enemy = Instantiate(enemigos[Random.Range(0, enemigos.Length)], spawnposition, gameObject.transform.rotation);

    }

    public void SpawnAlly()
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);

        spawnposition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(xRangeDown.position.y, xRangeUp.position.y), 0);

        GameObject ally = Instantiate(aliados[Random.Range(0, aliados.Length)], spawnposition, gameObject.transform.rotation);

    }
}
