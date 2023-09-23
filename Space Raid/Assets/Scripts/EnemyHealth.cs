using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 3;
    public float damage = 1;

    public void takeDamage(float damage)
    {
        health -= damage;

        

        if (health <= 0)
        {
            Die();
        }
    }

    public float GetHealth()
    {
        return health;
    }


    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        health player = hitInfo.GetComponent<health>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }

}
