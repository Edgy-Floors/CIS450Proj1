using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.isTrigger == false)
        {
            collision.gameObject.GetComponent<HealthSystem>().TakeDamage();
        }
    }
}
