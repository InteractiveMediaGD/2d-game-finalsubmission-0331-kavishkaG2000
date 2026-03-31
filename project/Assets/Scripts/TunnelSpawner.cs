using UnityEngine;

public class TunnelSpawner : MonoBehaviour
{
    public GameObject tunnelPrefab;
    public float spawnRate = 3f;
    public float spawnX = 10f;
    public float minY = -1.5f;
    public float maxY = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnTunnel), 1f, spawnRate);
    }

    void SpawnTunnel()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0f);
        Instantiate(tunnelPrefab, spawnPos, Quaternion.identity);
    }
}