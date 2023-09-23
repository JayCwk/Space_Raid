using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public GameObject bossBullet;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > 3)
        {
            timer = 0;
            Destroy(bossBullet);
        }
    }

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
