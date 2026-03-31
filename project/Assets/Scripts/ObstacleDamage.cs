using UnityEngine;

public class ObstacleDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.touchedObstacle = true;
                health.TakeDamage(damage);
            }
        }
    }
}