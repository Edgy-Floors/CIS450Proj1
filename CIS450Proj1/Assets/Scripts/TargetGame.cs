/*
 * Nick Grinstead
 * TargetGame.cs
 * This script handles the logic for the target clicking mini-game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float timeLimit;
    [SerializeField] float targetUpdateFrequency;
    float timePassed = 0;

    [SerializeField] int maxTargets = 5;
    ClickableTarget[] targetArray;
    [SerializeField] GameObject targetPrefab;

    PlayerInputs playerInputs;

    /// <summary>
    /// Sets variables
    /// </summary>
    private void Awake()
    {
        targetArray = new ClickableTarget[maxTargets];

        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

    /// <summary>
    /// Called to start this game, sets up the targets and UI
    /// </summary>
    public void StartGame()
    {
        playerInputs.CanMove = false;

        for (int i = 0; i < maxTargets; ++i)
        {
            targetArray[i] = Instantiate(targetPrefab).GetComponent<ClickableTarget>();

            targetArray[i].MoveTarget();
        }

        timePassed = 0;

        timer.enabled = true;
        timer.text = "Get points for every target you click!\nRemaining Time:\n" + timeLimit.ToString();

        StartCoroutine(GameTimer());
    }

    /// <summary>
    /// Ends the game by removing the targets and hiding the UI
    /// </summary>
    private void StopGame()
    {
        StopAllCoroutines();

        for (int i = 0; i < maxTargets; ++i)
        {
            targetArray[i].DestroyTarget();
        }

        timer.enabled = false;

        playerInputs.CanMove = true;
    }

    /// <summary>
    /// Called by the GameTimer coroutine to update the positions of the targets
    /// </summary>
    private void UpdatePositions()
    {
        for (int i = 0; i < maxTargets; ++i)
        {
            targetArray[i].MoveTarget();
        }
    }

    /// <summary>
    /// Coroutine that handles both the mini-game timer and the timing of targets
    /// updating their positions
    /// </summary>
    /// <returns>Waits for 1 second</returns>
    IEnumerator GameTimer()
    {
        while (true)
        {
            timePassed += 1;

            timer.text = "Get points for every target you click!\nRemaining Time:\n" + (timeLimit - timePassed).ToString();

            // Checks to see if game is over
            if (timePassed >= timeLimit)
            {
                StopGame();
            }

            // Checks if targets should update
            if (timePassed % targetUpdateFrequency == 0)
            {
                UpdatePositions();
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
