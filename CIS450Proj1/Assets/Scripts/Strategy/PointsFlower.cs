/*
 * Nick Grinstead
 * PointsFlower.cs
 * This script represents a flower that adds points when smelt.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsFlower : SmellBehavior
{
    bool hasBeenSmelt = false;
    PlayerInputs playerInputs;

    /// <summary>
    /// Sets up variables
    /// </summary>
    private void Awake()
    {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();

        smellBehaviorIndex = 3;
    }

    /// <summary>
    /// Gives the player points
    /// </summary>
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
