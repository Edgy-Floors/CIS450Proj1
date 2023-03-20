/*
 * Nick Grinstead
 * TimingGame.cs
 * This script handles the logic for the timing game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class TimingGame : MonoBehaviour
{
    [SerializeField] GameObject background, movingBar, targetZone;
    PlayerInputs playerInputs;
    [SerializeField] TextMeshProUGUI instructionsText;
    PlayerControls playerControls;
    InputAction stop;
    MovingBar movingBarScript;
    AudioSource success;
    AudioSource fail;

    /// <summary>
    /// Assigns audioSource components
    /// </summary>
    private void Start()
    {
        success = GameObject.FindGameObjectWithTag("success").GetComponent<AudioSource>();
        fail = GameObject.FindGameObjectWithTag("fail").GetComponent<AudioSource>();
    }

    /// <summary>
    /// Sets up variables and inputs
    /// </summary>
    private void Awake()
    {
        movingBarScript = movingBar.GetComponent<MovingBar>();

        playerControls = new PlayerControls();
        playerControls.MiniGameActions.Enable();

        stop = playerControls.FindAction("StopTimingBar");

        stop.performed += ctx => StopMovingBar();

        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

    /// <summary>
    /// Starts the game by enabling the game's UI
    /// </summary>
    public void StartGame()
    {
        playerInputs.CanMove = false;

        background.SetActive(true);
        movingBar.SetActive(true);
        targetZone.SetActive(true);
        instructionsText.text = "Press Space to Stop the Bar in the Target Zone!";
        instructionsText.enabled = true;

        movingBar.transform.localPosition = Vector2.zero;
        movingBar.GetComponent<MovingBar>().enabled = true;

        Vector2 newTargetPosition = targetZone.transform.localPosition;
        newTargetPosition.x = Random.Range(-0.42f, 0.42f);
        targetZone.transform.localPosition = newTargetPosition;
    }

    /// <summary>
    /// Stops the moving bar when the player gives an input and then checks if
    /// they succeeded
    /// </summary>
    private void StopMovingBar()
    {
        if (movingBarScript.CanMove)
        {
            movingBarScript.CanMove = false;

            if (Mathf.Abs(Vector3.Distance(targetZone.transform.position, movingBar.transform.position)) <= 0.5f)
            {
                GameObject.FindGameObjectWithTag("Subject").GetComponent<FlowerData>().updateScore(15);

                instructionsText.text = "You won the mini-game!";
                success.Play();
            }
            else
            {
                instructionsText.text = "You missed the target.";
                fail.Play();
            }

            Invoke("StopGame", 1.2f);
        }
    }

    private void StopGame()
    {
        playerInputs.CanMove = true;

        background.SetActive(false);
        movingBar.SetActive(false);
        targetZone.SetActive(false);
        instructionsText.enabled = false;
    }

    /// <summary>
    /// Changes the travel direction of the moving bar when it hits the ends of
    /// the zone
    /// </summary>
    private void Update()
    {
        if (Mathf.Abs(Vector3.Distance(background.transform.position, movingBar.transform.position)) >= 3)
        {
            movingBar.GetComponent<MovingBar>().TravelDir *= -1;
        }
    }

    /// <summary>
    /// Enables inputs
    /// </summary>
    private void OnEnable()
    {
        playerControls.MiniGameActions.Enable();
    }

    /// <summary>
    /// Disables inputs
    /// </summary>
    private void OnDisable()
    {
        playerControls.MiniGameActions.Disable();
    }
}
