using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public TextMeshProUGUI healthText;
    public GameObject gameOverUI; // assign GameOverPanel here

    [HideInInspector] public bool touchedObstacle = false;

    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();

        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth < 0)
            currentHealth = 0;

        UpdateHealthUI();

        if (currentHealth == 0)
        {
            GameOver();
        }
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth += amount;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        UpdateHealthUI();
    }

    void GameOver()
    {
        isDead = true;
        Time.timeScale = 0f;

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);

            TextMeshProUGUI text = gameOverUI.GetComponentInChildren<TextMeshProUGUI>();

            if (text != null)
            {
                text.text =
                    "GAME OVER\n\n" +
                    "Score: " + GameManager.instance.score + "\n\n" +
                    "Press R to Restart";
            }
        }
    }

    void Update()
    {
        if (isDead && Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;

            float t = (float)currentHealth / maxHealth;
            healthText.color = Color.Lerp(Color.red, Color.green, t);
        }
    }
}