using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlowerData : MonoBehaviour, ISubject
{
    private List<IObserver> obs = new List<IObserver>();

    [Tooltip("Amount of good flowers that have been smelled.")]
    public int goodCcount = 0;

    [Tooltip("Amount of points acquired from smelling flowers.")]
    public int points = 0;

    [Tooltip("Text to update on UI for the counter.")]
    public TextMeshProUGUI txt;

    public void onObserve()
    {
        foreach(IObserver x in obs)
        {
            x.updateCount(points);
        }
    }

    public void startObserve(IObserver o)
    {
        obs.Add(o);
        o.updateCount(points);
    }

    public void stopObserve(IObserver o)
    {
        if(obs.Contains(o))
        {
            obs.Remove(o);
        }
    }
}
