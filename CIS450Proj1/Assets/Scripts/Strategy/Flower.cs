using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    SmellBehavior smellBehavior;
    bool hasBeenWatered = false;

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

    public void UpdateSmellBehavior()
    {
        if (!hasBeenWatered)
        {
            bool newBehaviorFound = false;
            int newBehaviorIndex = 0;

            while (!newBehaviorFound)
            {
                newBehaviorIndex = Random.Range(0, 4);

                if (newBehaviorIndex != smellBehavior.smellBehaviorIndex)
                {
                    newBehaviorFound = true;
                }
            }

            Destroy(smellBehavior);

            switch (newBehaviorIndex)
            {
                case 0:
                    smellBehavior = gameObject.AddComponent<TimingFlower>();
                    break;

                case 1:
                    smellBehavior = gameObject.AddComponent<TargetFlower>();
                    break;

                case 2:
                    smellBehavior = gameObject.AddComponent<MemoryFlower>();
                    break;

                case 3:
                default:
                    smellBehavior = gameObject.AddComponent<PointsFlower>();
                    break;
            }
        }
    }
}
