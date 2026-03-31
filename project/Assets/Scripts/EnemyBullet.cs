using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 3f;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
        else if (!other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}