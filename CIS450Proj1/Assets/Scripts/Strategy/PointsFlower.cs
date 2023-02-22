using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsFlower : SmellBehavior
{
    bool hasBeenSmelt = false;
    [SerializeField] PlayerInputs playerInputs;

    private void Awake()
    {
        smellBehaviorIndex = 3;
    }

    public override void Smell()
    {
        if (!hasBeenSmelt)
        {
            // call FlowerData to add points

            playerInputs.CanMove = true;

            Debug.Log("The player gained free points!");
        }
    }
}
