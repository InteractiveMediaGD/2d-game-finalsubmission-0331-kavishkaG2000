using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public int scoreValue = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Hit by projectile
        if (other.CompareTag("Projectile"))
        {
            GameManager.instance.AddScore(scoreValue);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        // Hit player
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}