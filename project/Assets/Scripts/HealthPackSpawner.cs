using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    public GameObject healthPackPrefab;
    public float spawnRate = 6f;
    public float spawnX = 10f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnHealthPack), 3f, spawnRate);
    }

    void SpawnHealthPack()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0f);
        Instantiate(healthPackPrefab, spawnPos, Quaternion.identity);
    }
}