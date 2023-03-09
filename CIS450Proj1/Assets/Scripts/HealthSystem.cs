using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private TextMeshProUGUI healthText;

    [SerializeField] GameObject gameEndUI;
    [SerializeField] TextMeshProUGUI endGameText;

    public void TakeDamage()
    {
        health--;
        Debug.Log(health);
    }

    private void Update()
    {
        healthText.text = "Health: " + health;

        if (health <= 0)
        {
            gameEndUI.SetActive(true);
            endGameText.text = "Game Over\nTake a deep breath and try again!";

            Time.timeScale = 0;
        }
    }
}
