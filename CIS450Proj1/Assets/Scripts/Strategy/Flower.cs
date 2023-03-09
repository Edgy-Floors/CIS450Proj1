/*
 * Nick Grinstead
 * Flower.cs
 * This class represents a flower object that can be smelled and watered.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public SmellBehavior smellBehavior;
    bool hasBeenWatered = false;
    FlowerSpawner flowerSpawner;

    private void Awake()
    {

        flowerSpawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<FlowerSpawner>();
    }

    public void GetSmellBehavior()
    {
        smellBehavior = GetComponent<SmellBehavior>();
    }

    /// <summary>
    /// Called when this flower is smelt to calls Smell() on smellBehavior
    /// </summary>
    public void SmellFlower()
    {
        if (smellBehavior != null)
        {
            smellBehavior.Smell();

            Debug.Log("A flower was smelt");

            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("No smell");
        }
    }

    /// <summary>
    /// Called when this flower is watered to randomize its SmellBehavior
    /// </summary>
    public void UpdateSmellBehavior()
    {
        if (!hasBeenWatered)
        {
            bool newBehaviorFound = false;
            int newBehaviorIndex = 0;

            // Chooses a random behavior that's different from this flower's
            // current behavior
            while (!newBehaviorFound)
            {
                newBehaviorIndex = Random.Range(0, 4);

                if (newBehaviorIndex != smellBehavior.smellBehaviorIndex)
                {
                    newBehaviorFound = true;
                }
            }

            Destroy(smellBehavior);

            // Sets smellBehavior based on newBehaviorIndex
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

            gameObject.GetComponent<SpriteRenderer>().sprite = flowerSpawner.flowerSprites[smellBehavior.smellBehaviorIndex];

            hasBeenWatered = true;
        }
    }
}
