using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health player = collision.GetComponent<health>();
            if (player != null)
            {
                player.AddHealth(1);
            }
            Destroy(gameObject);

        }
    }
}
