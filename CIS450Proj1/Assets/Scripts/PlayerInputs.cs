/*
 * Nick Grinstead
 * PlayerInputs.cs
 * Handles player inputs and allows them to move, smell flowers, and water flowers.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    PlayerControls playerControls;
    InputAction walk, run, smell, water;

    bool isRunning = false;
    Vector2 moveDirection;
    [SerializeField] float baseSpeed;
    [SerializeField] float runSpeed;

    /// <summary>
    /// Sets up inputs on Awake
    /// </summary>
    private void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.BasicActions.Enable();

        walk = playerControls.FindAction("Walk");
        run = playerControls.FindAction("Run");
        smell = playerControls.FindAction("Smell");
        water = playerControls.FindAction("Water");

        walk.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        walk.canceled += ctx => moveDirection = ctx.ReadValue<Vector2>();

        run.performed += ctx => isRunning = true;
        run.canceled += ctx => isRunning = false;

        smell.performed += ctx => Smell();
        water.performed += ctx => Water();
    }

    /// <summary>
    /// Has the character move at one of two speeds based on isRunning
    /// </summary>
    private void Update()
    {
        Vector2 moveVelocity;

        if (isRunning)
        {
            moveVelocity = moveDirection * runSpeed * Time.deltaTime;
        }
        else
        {
            moveVelocity = moveDirection * baseSpeed * Time.deltaTime;
        }

        transform.Translate(moveVelocity);
    }

    private void Smell()
    {
        Debug.Log("A flower was smelt!");
        // Actual functionallity to be added later
    }

    private void Water()
    {
        Debug.Log("A flower was watered!");
        // Actual functionallity to be added later
    }

    /// <summary>
    /// Enables the player's controls
    /// </summary>
    private void OnEnable()
    {
        playerControls.BasicActions.Enable();
    }

    /// <summary>
    /// Disables the player's controls
    /// </summary>
    private void OnDisable()
    {
        playerControls.BasicActions.Disable();
    }
}
