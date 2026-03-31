using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public Transform firePoint;
    public float fireRate = 2f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        if (enemyBulletPrefab != null && firePoint != null)
        {
            Instantiate(enemyBulletPrefab, firePoint.position, Quaternion.identity);
        }
    }
}