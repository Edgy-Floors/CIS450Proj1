/*
 * Chandler Wesoloski
 * FlowerSpawner.cs
 * Project 2
 * Contains the logic for making a flower for the flower spawner.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFlowerFactory : MonoBehaviour
{
    [SerializeField] private GameObject[] flowers;

    public GameObject MakeFlower(string flowerType)
    {
        switch (flowerType)
        {
            case "YellowFlower":
                return flowers[0];
            case "OrangeFlower":
                return flowers[1];
            case "RedFlower":
                return flowers[2];
            case "BlueFlower":
                return flowers[3];
            default:
                return flowers[0];
        }
    }
}
