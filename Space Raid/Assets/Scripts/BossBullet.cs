using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public GameObject bossBullet;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health player = collision.GetComponent<health>();
            if (player != null)
            {
                player.TakeDamage(1);
                Destroy(gameObject);
            }
            
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("isGround"))
        {
            Destroy(gameObject); 
        }
    }
}
