using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinMessage : MonoBehaviour, IObserver
{
    [SerializeField] GameObject gameEndUI;
    [SerializeField] TextMeshProUGUI endGameText;

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Subject").GetComponent<ISubject>().startObserve(this);
    }

    public void updateCount(int count, int target)
    {
        if (count >= target)
        {
            gameEndUI.SetActive(true);
            endGameText.text = "Congratulations!\nYou've completed the game!";

            Time.timeScale = 0;
        }
    }
}
