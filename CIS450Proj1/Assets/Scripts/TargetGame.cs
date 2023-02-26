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

    [SerializeField] PlayerInputs playerInputs;

    private void Awake()
    {
        targetArray = new ClickableTarget[maxTargets];

        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

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
        timer.text = "Click the Targets!\nRemaining Time:\n" + timeLimit.ToString();

        StartCoroutine(GameTimer());
    }

    private void StopGame()
    {
        for (int i = 0; i < maxTargets; ++i)
        {
            targetArray[i].DestroyTarget();
        }

        timer.enabled = false;

        playerInputs.CanMove = true;
    }

    private void UpdatePositions()
    {
        for (int i = 0; i < maxTargets; ++i)
        {
            targetArray[i].MoveTarget();
        }
    }

    IEnumerator GameTimer()
    {
        while (true)
        {
            timePassed += 1;

            timer.text = "Click the Targets!\nRemaining Time:\n" + (timeLimit - timePassed).ToString();

            if (timePassed >= timeLimit)
            {
                StopGame();

                StopCoroutine(GameTimer());
            }

            if (timePassed % targetUpdateFrequency == 0)
            {
                UpdatePositions();
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
