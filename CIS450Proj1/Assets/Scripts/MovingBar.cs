/*
 * Nick Grinstead
 * MovingBar.cs
 * This script handles the behavior of the moving bar used in the timing mini-game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovingBar : MonoBehaviour
{
    [SerializeField] float movingBarSpeed;
    InputAction stop;
    private int travelDir = 1;
    public bool canMove = false;

    public int TravelDir { get => travelDir; set => travelDir = value; }
    public bool CanMove { get => canMove; set => canMove = value; }

    /// <summary>
    /// Moves the bar in a direction based on travelDir
    /// </summary>
    void Update()
    {
        if (canMove)
        {
            if (TravelDir == 1)
            {
                transform.Translate(Vector3.right * movingBarSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * movingBarSpeed * Time.deltaTime);
            }
        }
    }

    /// <summary>
    /// Allows bar to move when enabled
    /// </summary>
    private void OnEnable()
    {
        CanMove = true;
    }

    /// <summary>
    /// Stops bar from moving when disabled
    /// </summary>
    private void OnDisable()
    {
        CanMove = false;
    }
}
