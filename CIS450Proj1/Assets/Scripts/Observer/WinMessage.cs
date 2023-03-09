using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMessage : MonoBehaviour, IObserver
{
    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Subject").GetComponent<ISubject>().startObserve(this);
    }

    public void updateCount(int count, int target)
    {
        if (count >= target)
        {
            // reveal win message
        }
    }
}
