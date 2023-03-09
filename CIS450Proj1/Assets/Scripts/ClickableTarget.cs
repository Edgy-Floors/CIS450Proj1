/*
 * Nick Grinstead
 * ClickableTarget.cs
 * This script represents a moving target used in the target mini-game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTarget : MonoBehaviour
{
    /// <summary>
    /// Moves the target and adds points when clicked
    /// </summary>
    private void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("Subject").GetComponent<FlowerData>().updateScore(1);

        MoveTarget();
    }

    /// <summary>
    /// Called to move this target to a random position
    /// </summary>
    public void MoveTarget()
    {
        if (this != null)
        {
            Vector2 posChange = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4f, 4f));
            transform.position = (Vector2)Camera.main.transform.position + posChange;
        }
    }

    /// <summary>
    /// Called by TargetGame to destroy this target object
    /// </summary>
    public void DestroyTarget()
    {
        if (this != null)
        {
            Destroy(gameObject);
        }
    }
}
