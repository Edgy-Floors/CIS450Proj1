using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsFlower : SmellBehavior
{
    bool hasBeenSmelt = false;

    public override void Smell()
    {
        if (!hasBeenSmelt)
        {
            // call FlowerData to add points

            Debug.Log("The player gained free points!");
        }
    }
}
