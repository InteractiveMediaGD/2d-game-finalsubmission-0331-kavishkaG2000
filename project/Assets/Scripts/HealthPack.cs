using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.Heal(healAmount);
            }

            Destroy(gameObject);
        }
    }
}