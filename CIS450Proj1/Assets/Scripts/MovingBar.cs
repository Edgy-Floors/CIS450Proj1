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

    // Update is called once per frame
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

    private void OnEnable()
    {
        CanMove = true;
    }

    private void OnDisable()
    {
        CanMove = false;
    }
}
