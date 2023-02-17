using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    SmellBehavior smellBehavior;

    private void Awake()
    {
        smellBehavior = GetComponent<SmellBehavior>();
    }

    public void SmellFlower()
    {
        if (smellBehavior != null)
        {
            smellBehavior.Smell();

            Debug.Log("A flower was smelt");
        }
    }
}
