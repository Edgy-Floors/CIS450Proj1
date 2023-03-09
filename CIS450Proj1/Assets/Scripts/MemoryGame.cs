/*
 * Nick Grinstead
 * MemoryGame.cs
 * This script handles the logic for the memory game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class MemoryGame : MonoBehaviour
{
    PlayerControls playerControls;
    InputAction oneKey, twoKey, threeKey, fourKey, fiveKey, sixKey, sevenKey, eightKey, nineKey;

    PlayerInputs playerInputs;

    int currentIndex = 0;
    int[] inputSequence = new int[4];
    int[] targetMemorySequence = new int[4];

    [SerializeField] TextMeshProUGUI memorySequenceText;

    bool inputsActive = false;

    /// <summary>
    /// Sets up variables and inputs
    /// </summary>
    private void Awake()
    {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();

        playerControls = new PlayerControls();
        playerControls.MiniGameActions.Enable();

        oneKey = playerControls.FindAction("1Key");
        twoKey = playerControls.FindAction("2Key");
        threeKey = playerControls.FindAction("3Key");
        fourKey = playerControls.FindAction("4Key");
        fiveKey = playerControls.FindAction("5Key");
        sixKey = playerControls.FindAction("6Key");
        sevenKey = playerControls.FindAction("7Key");
        eightKey = playerControls.FindAction("8Key");
        nineKey = playerControls.FindAction("9Key");

        oneKey.performed += ctx => AddToSequence(1);
        twoKey.performed += ctx => AddToSequence(2);
        threeKey.performed += ctx => AddToSequence(3);
        fourKey.performed += ctx => AddToSequence(4);
        fiveKey.performed += ctx => AddToSequence(5);
        sixKey.performed += ctx => AddToSequence(6);
        sevenKey.performed += ctx => AddToSequence(7);
        eightKey.performed += ctx => AddToSequence(8);
        nineKey.performed += ctx => AddToSequence(9);
    }

    /// <summary>
    /// Starts game by generating a sequence and enabling the UI
    /// </summary>
    public void StartGame()
    {
        playerInputs.CanMove = false;

        for (int i = 0; i < targetMemorySequence.Length; ++i)
        {
            targetMemorySequence[i] = Random.Range(1, 10);
        }

        memorySequenceText.enabled = true;
        memorySequenceText.text = "Remember this 4 Number Sequence:\n";

        StartCoroutine(RevealSequence());
    }

    /// <summary>
    /// Stops the game and compares player inputs to the target sequence
    /// </summary>
    private void StopGame()
    {
        int totalCorrect = 0;

        for (int i = 0; i < targetMemorySequence.Length; ++i)
        {
            if (targetMemorySequence[i] == inputSequence[i])
            {
                totalCorrect++;
            }
        }

        memorySequenceText.text = "You got " + totalCorrect + " correct!\n+" + totalCorrect * 5 + " points";
        GameObject.FindGameObjectWithTag("Subject").GetComponent<FlowerData>().updateScore(5 * totalCorrect);

        Invoke("Reset", 1.2f);
    }

    private void Reset()
    {
        memorySequenceText.text = "Remember this 4 Number Sequence:\n";
        memorySequenceText.enabled = false;

        playerInputs.CanMove = true;
    }

    /// <summary>
    /// Allows player to use number keys to add numbers to their input sequence
    /// </summary>
    /// <param name="inputVal">The number they typed</param>
    private void AddToSequence(int inputVal)
    {
        if (inputsActive)
        {
            inputSequence[currentIndex] = inputVal;

            memorySequenceText.text += ("  " + inputVal);

            currentIndex++;

            // Stops the game once a player has typed their full sequence
            if (currentIndex >= targetMemorySequence.Length)
            {
                inputsActive = false;
                StopGame();
            }
        }
    }

    /// <summary>
    /// Coroutine that reveals the target sequence to the player one number at
    /// a time
    /// </summary>
    /// <returns>Waits for a specific amount of time</returns>
    IEnumerator RevealSequence()
    {
        yield return new WaitForSeconds(1.5f);

        for (int i = 0; i < targetMemorySequence.Length; ++i)
        {
            memorySequenceText.text += ("  " + targetMemorySequence[i]);

            yield return new WaitForSeconds(0.75f);
        }

        inputsActive = true;
        currentIndex = 0;

        memorySequenceText.text = "Repeat the Sequence using the Number Keys:\n";

        StopCoroutine(RevealSequence());
    }
}
