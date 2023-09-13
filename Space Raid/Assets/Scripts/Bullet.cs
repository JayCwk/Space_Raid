using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1;
    public Rigidbody2D rb;
    public GameObject impact;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.takeDamage(damage);
        }

        Instantiate(impact, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
