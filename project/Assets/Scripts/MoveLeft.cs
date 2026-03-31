using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float extraSpeed = 0f;

    void Update()
    {
        float speed = 2f;

        if (SpeedManager.instance != null)
        {
            speed = SpeedManager.instance.currentSpeed + extraSpeed;
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}