using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class MemoryGame : MonoBehaviour
{
    PlayerControls playerControls;
    InputAction oneKey, twoKey, threeKey, fourKey, fiveKey, sixKey, sevenKey, eightKey, nineKey;

    [SerializeField] PlayerInputs playerInputs;

    int currentIndex = 0;
    int[] inputSequence = new int[4];
    int[] targetMemorySequence = new int[4];

    [SerializeField] TextMeshProUGUI memorySequenceText;

    bool inputsActive = false;

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

        // Would add points here based on totalCorrect
        Debug.Log("You got " + totalCorrect + " matches");

        memorySequenceText.text = "Remember this 4 Number Sequence:\n";
        memorySequenceText.enabled = false;

        playerInputs.CanMove = true;
    }

    private void AddToSequence(int inputVal)
    {
        if (inputsActive)
        {
            inputSequence[currentIndex] = inputVal;

            memorySequenceText.text += ("  " + inputVal);

            currentIndex++;

            if (currentIndex >= targetMemorySequence.Length)
            {
                inputsActive = false;
                StopGame();
            }
        }
    }

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
