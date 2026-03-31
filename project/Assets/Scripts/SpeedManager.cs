using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static SpeedManager instance;

    public float currentSpeed = 2f;
    public float maxSpeed = 6f;
    public float increaseRate = 0.15f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += increaseRate * Time.deltaTime;
        }
    }
}