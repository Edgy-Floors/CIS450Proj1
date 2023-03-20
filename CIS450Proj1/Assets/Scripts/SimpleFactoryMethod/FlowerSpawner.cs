/*
 * Chandler Wesoloski
 * FlowerSpawner.cs
 * Project 2
 * Contains the logic for spawning flowers at a location
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    [SerializeField] private SimpleFlowerFactory flowerFactory;
    [SerializeField] private string[] flowerTypes;
    private const int zCoord = 0;

    [Tooltip("The min X coordinate the flowers can spawn")]
    public int minX;
    [Tooltip("The main Y coordinate the flowers can spawn")]
    public int minY;
    [Tooltip("The max X coordinate the flowers can spawn")]
    public int maxX;
    [Tooltip("The max Y coordinate the flowers can spawn")]
    public int maxY;

    [Tooltip("The amount of flowers to be spawned")]
    public int flowerAmount = 0;

    private void Awake()
    {
        flowerFactory = GetComponent<SimpleFlowerFactory>();
    }

    private void Start()
    {

        for (int i = 0; i < flowerAmount; i++)
        {
            int _randFlower = Random.Range(0, flowerTypes.Length - 1);

            Vector3 _spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

            Instantiate(flowerFactory.MakeFlower(flowerTypes[_randFlower]), _spawnPos, Quaternion.identity);
        }
    }
}