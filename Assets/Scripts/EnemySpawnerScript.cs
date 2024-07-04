using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemyPrefabLeft;
    [SerializeField] private GameObject _enemyPrefabRight;

    public void Spawn()
    {        
        int num = UnityEngine.Random.Range(0, _spawnPoints.Length);
        Transform randomSpawnPoint = _spawnPoints[num];
        randomSpawnPoint.position = new Vector3(randomSpawnPoint.transform.position.x, randomSpawnPoint.transform.position.y, 0);
        if (num < 2)
        {
            Instantiate(_enemyPrefabLeft, randomSpawnPoint.position, Quaternion.identity);
            Debug.Log("Враг заспавнен в точке: " + randomSpawnPoint.position);
        }
        else
        {
            Instantiate(_enemyPrefabRight, randomSpawnPoint.position, Quaternion.identity);
            Debug.Log("Враг заспавнен в точке: " + randomSpawnPoint.position);
        }
    }
}
