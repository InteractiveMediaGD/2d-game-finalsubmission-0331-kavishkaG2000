using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 0.75f;

    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.World);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}