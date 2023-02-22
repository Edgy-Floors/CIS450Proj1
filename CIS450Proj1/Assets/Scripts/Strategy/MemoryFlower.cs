using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryFlower : SmellBehavior
{
    bool hasBeenSmelt = false;

    private void Awake()
    {
        smellBehaviorIndex = 2;
    }

    public override void Smell()
    {
        if (!hasBeenSmelt)
        {
            MemoryGame mg = GameObject.FindGameObjectWithTag("GameController").GetComponent<MemoryGame>();

            if (mg != null)
            {
                mg.StartGame();
            }

            hasBeenSmelt = true;

            Debug.Log("Memory mini-game started");
        }
    }
}
