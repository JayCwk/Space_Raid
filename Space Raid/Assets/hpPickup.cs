using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpPickup : MonoBehaviour
{
    [SerializeField] private AudioClip collectsound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health player = collision.GetComponent<health>();
            if (player != null)
            {
                player.AddHealth(1);
                soundmanager.instance.PlaySound(collectsound);
            }
            Destroy(gameObject);

        }
    }
}
