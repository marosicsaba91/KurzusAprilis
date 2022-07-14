using UnityEngine;
using TMPro;

public class Damagable : MonoBehaviour
{
    public int health = 3;
    [SerializeField] TMP_Text healthText;
    [SerializeField] GameObject gameOverScreen;

    int startHealth;

    void Start()
    {
        startHealth = health;
        UpdateText();
    }

    public void DoDamage(int damage)
    {
        if (health <= 0)
            return;

        if (health >= damage)
            health -= damage;
        else
            health = 0;

        UpdateText();

        if (gameOverScreen != null && health <= 0)
            gameOverScreen.SetActive(true);   
    }

    void UpdateText()
    {
        if (healthText != null) 
                healthText.text = $"Health: {health}";
    }

    public void RestartDamagable() 
    {
        health = startHealth;
        gameOverScreen.SetActive(false);
        UpdateText();
    }
}
