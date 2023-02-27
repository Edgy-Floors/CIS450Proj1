/*
 * Chandler Wesoloski
 * FlowerSpawner.cs
 * Project 2
 * Contains the logic for spawning flowers and assigning smell behavior
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] flowers = new GameObject[4];
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

    private void Start()
    {
        for (int i = 0; i < flowerAmount; i++)
        {
            Flower _Tempflowerscript;
            int _randFlower = Random.Range(0, flowers.Length - 1);
            int _randSmellBehavior = Random.Range(0, 4);
            Vector3 _spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

            GameObject _temp = Instantiate(flowers[_randFlower], _spawnPos, Quaternion.identity);

            _Tempflowerscript = _temp.GetComponent<Flower>();

            switch (_randSmellBehavior)
            {
                case 0:
                    _temp.AddComponent<MemoryFlower>();
                    _Tempflowerscript.GetSmellBehavior();
                    break;
                case 1:
                    _temp.AddComponent<PointsFlower>();
                    _Tempflowerscript.GetSmellBehavior();
                    break;
                case 2:
                    _temp.AddComponent<TargetFlower>();
                    _Tempflowerscript.GetSmellBehavior();
                    break;
                case 3:
                    _temp.AddComponent<TimingFlower>();
                    _Tempflowerscript.GetSmellBehavior();
                    break;
            }
        }
    }
}