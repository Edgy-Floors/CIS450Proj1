/*
 * Nick Grinstead
 * PlayerInputs.cs
 * Handles player inputs and allows them to move, smell flowers, and water flowers.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerInputs : MonoBehaviour
{
    PlayerControls playerControls;
    InputAction walk, smell, water;

    //bool isRunning = false;
    bool canMove = true;
    Vector2 moveDirection;
    [SerializeField] float baseSpeed;
    //[SerializeField] float runSpeed;

    [SerializeField] Flower currentFlower;
    // Below will be removed soon - currently just for playtesting
    public int points = 0;
    public TextMeshProUGUI tmp;

    public bool CanMove { get => canMove; set => canMove = value; }
    private Rigidbody2D rb;

    /// <summary>
    /// Sets up inputs on Awake
    /// </summary>
    private void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.BasicActions.Enable();

        walk = playerControls.FindAction("Walk");
        //run = playerControls.FindAction("Run");
        smell = playerControls.FindAction("Smell");
        water = playerControls.FindAction("Water");

        walk.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        walk.canceled += ctx => moveDirection = ctx.ReadValue<Vector2>();

        //run.performed += ctx => isRunning = true;
        //run.canceled += ctx => isRunning = false;

        smell.performed += ctx => Smell();
        water.performed += ctx => Water();
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Has the character move at one of two speeds based on isRunning
    /// </summary>
    private void FixedUpdate()
    {
        Vector2 moveVelocity;

        moveVelocity = moveDirection * baseSpeed * Time.fixedDeltaTime;
        
        if (CanMove)
        {
            rb.velocity = moveVelocity;
        }
    }

    /// <summary>
    /// Calls SmellFlower() on currentFlower if there is a flower to smell
    /// </summary>
    private void Smell()
    {
        if (currentFlower != null)
        {
            currentFlower.SmellFlower();
            points += 10;
            tmp.text = "Points: " + points;
        }
    }

    /// <summary>
    /// Updates currentFlower's SmellBehavior
    /// </summary>
    private void Water()
    {
        Debug.Log("A flower was watered!");
        
        if (currentFlower != null)
        {
            currentFlower.UpdateSmellBehavior();
        }
    }

    /// <summary>
    /// Sets currentFlower when near a flower
    /// </summary>
    /// <param name="collision">Data related to a collision</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            currentFlower = collision.gameObject.GetComponent<Flower>();
        }
    }

    /// <summary>
    /// Clears out currentFlower when walking away from a flower
    /// </summary>
    /// <param name="collision">Data related to a collision</param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            currentFlower = null;
        }
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
