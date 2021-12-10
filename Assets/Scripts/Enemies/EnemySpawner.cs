using System.Collections;
using UnityEngine;

[RequireComponent(typeof(EnemyFactory))]

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnTime = 10.0f;
    [SerializeField] private int maxWaves = 3;

    private EnemyFactory factory;
    private Transform[] spawnPoints;
    private int currentWave = 1;

    private void Awake()
    {
        factory = GetComponent<EnemyFactory>();
        spawnPoints = GetComponentsInChildren<Transform>();
    }

    private void Start()
    {
        SpawnWave();
        StartCoroutine(WaveTimer());
    }

    private void SpawnWave()
    {
        foreach (Transform spawn in spawnPoints)
        {
            BaseEnemy spawnedEnemy = factory.GetEnemy((EnemyType) Random.Range(0, 3), currentWave);
            spawnedEnemy.transform.SetPositionAndRotation(spawn.position, spawn.rotation);
        }
        currentWave++;
    }
    
    private IEnumerator WaveTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        if (currentWave > maxWaves) yield break;
        SpawnWave();
        StartCoroutine(WaveTimer());
    }
}
