using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    ISmellBehavior smellBehavior = new TimingFlower();

    public void SmellFlower()
    {
        smellBehavior.Smell();

        Debug.Log("A flower was smelt");
    }
}
