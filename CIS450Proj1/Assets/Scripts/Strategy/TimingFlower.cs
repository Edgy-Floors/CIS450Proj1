using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingFlower : SmellBehavior
{
    bool hasBeenSmelt = false;

    public override void Smell()
    {
        if (!hasBeenSmelt)
        {
            TimingGame tg = GameObject.FindGameObjectWithTag("GameController").GetComponent<TimingGame>();

            if (tg != null)
            {
                tg.StartGame();
            }

            hasBeenSmelt = true;

            Debug.Log("Timing mini-game started");
        }
    }
}
