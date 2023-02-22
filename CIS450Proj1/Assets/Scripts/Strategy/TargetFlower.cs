using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFlower : SmellBehavior
{
    bool hasBeenSmelt = false;

    private void Awake()
    {
        smellBehaviorIndex = 1;
    }

    public override void Smell()
    {
        if (!hasBeenSmelt)
        {
            TargetGame tg = GameObject.FindGameObjectWithTag("GameController").GetComponent<TargetGame>();

            if (tg != null)
            {
                tg.StartGame();
            }

            hasBeenSmelt = true;

            Debug.Log("Target mini-game started");
        }
    }
}
