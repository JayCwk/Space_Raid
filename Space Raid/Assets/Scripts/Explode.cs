using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public int damage = 1;

    //public GameObject deathEffect;
    public GameObject enemy;


    void Die()
    {
        //Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(enemy);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health player = collision.GetComponent<health>();
        if(player != null)
        {
            player.TakeDamage(damage);
            Die();
        }
    }
}
