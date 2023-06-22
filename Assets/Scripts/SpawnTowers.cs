using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTowers : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject towerPrefab;
    public Transform[] enemyesSpawns;
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTower(int id)
    {
        GameObject tower = Instantiate(towerPrefab, spawnPos[id]);
    }

    public void spawnWave()
    {
        foreach (Transform t in enemyesSpawns)
        {
            GameObject enemy = Instantiate(enemyPrefab, t);
        }

        Invoke("spawnWave", 2);
    }
}
