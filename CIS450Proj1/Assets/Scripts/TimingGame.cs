using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class TimingGame : MonoBehaviour
{
    [SerializeField] GameObject background, movingBar, targetZone;
    [SerializeField] PlayerInputs playerInputs;
    [SerializeField] TextMeshProUGUI instructionsText;
    PlayerControls playerControls;
    InputAction stop;
    MovingBar movingBarScript;

    private void Awake()
    {
        movingBarScript = movingBar.GetComponent<MovingBar>();

        playerControls = new PlayerControls();
        playerControls.MiniGameActions.Enable();

        stop = playerControls.FindAction("StopTimingBar");

        stop.performed += ctx => StopMovingBar();

        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

    public void StartGame()
    {
        playerInputs.CanMove = false;

        background.SetActive(true);
        movingBar.SetActive(true);
        targetZone.SetActive(true);
        instructionsText.enabled = true;

        movingBar.GetComponent<MovingBar>().enabled = true;

        Vector2 newTargetPosition = targetZone.transform.localPosition;
        newTargetPosition.x = Random.Range(-0.42f, 0.42f);
        targetZone.transform.localPosition = newTargetPosition;
    }

    private void StopMovingBar()
    {
        if (movingBarScript.CanMove)
        {
            movingBarScript.CanMove = false;

            if (Mathf.Abs(Vector3.Distance(targetZone.transform.position, movingBar.transform.position)) <= 0.5f)
            {
                // call script to add points

                Debug.Log("You won the timeing game!");
            }
            else
            {
                Debug.Log("You lost the timing game");
            }

            playerInputs.CanMove = true;

            background.SetActive(false);
            movingBar.SetActive(false);
            targetZone.SetActive(false);
            instructionsText.enabled = false;
        }
    }

    private void Update()
    {
        if (Mathf.Abs(Vector3.Distance(background.transform.position, movingBar.transform.position)) >= 3)
        {
            movingBar.GetComponent<MovingBar>().TravelDir *= -1;
        }
    }
    private void OnEnable()
    {
        playerControls.MiniGameActions.Enable();
    }

    private void OnDisable()
    {
        playerControls.MiniGameActions.Disable();
    }
}
