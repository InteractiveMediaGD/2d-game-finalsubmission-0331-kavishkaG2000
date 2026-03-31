using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveY = -1f;
        }

        transform.Translate(Vector3.up * moveY * moveSpeed * Time.deltaTime);
    }
}
