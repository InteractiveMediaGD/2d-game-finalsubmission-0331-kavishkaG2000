using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (scored) return;

        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null && !health.touchedObstacle)
            {
                scored = true;
                GameManager.instance.AddScore(1);
            }

            if (health != null)
            {
                health.touchedObstacle = false;
            }
        }
    }
}