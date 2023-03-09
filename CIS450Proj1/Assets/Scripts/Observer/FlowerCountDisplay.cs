using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlowerCountDisplay : MonoBehaviour, IObserver
{
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Subject").GetComponent<ISubject>().startObserve(this);
    }

    public void updateCount(int count, int target)
    {
        scoreText.text = "Points: " + count + " / " + target;
    }
}
