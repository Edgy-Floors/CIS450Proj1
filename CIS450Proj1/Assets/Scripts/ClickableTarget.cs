using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTarget : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Calls script to add points

        Debug.Log("A target was hit");

        MoveTarget();
    }

    public void MoveTarget()
    {
        if (this != null)
        {
            Vector2 posChange = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4f, 4f));
            transform.position = (Vector2)Camera.main.transform.position + posChange;
        }
    }

    public void DestroyTarget()
    {
        if (this != null)
        {
            Destroy(gameObject);
        }
    }
}
