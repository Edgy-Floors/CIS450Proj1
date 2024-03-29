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
    public Sprite[] flowerSprites = new Sprite[4];

    private void Awake()
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
                    gameObject.GetComponent<SpriteRenderer>().sprite = flowerSprites[0];
                    break;

                case 1:
                    smellBehavior = gameObject.AddComponent<TargetFlower>();
                    gameObject.GetComponent<SpriteRenderer>().sprite = flowerSprites[1];
                    break;

                case 2:
                    smellBehavior = gameObject.AddComponent<MemoryFlower>();
                    gameObject.GetComponent<SpriteRenderer>().sprite = flowerSprites[2];
                    break;

                case 3:
                default:
                    smellBehavior = gameObject.AddComponent<PointsFlower>();
                    gameObject.GetComponent<SpriteRenderer>().sprite = flowerSprites[3];
                    break;
            }
            hasBeenWatered = true;
        }
    }
}
