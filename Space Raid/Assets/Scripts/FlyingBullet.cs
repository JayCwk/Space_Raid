using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float timer;

    public GameObject impact;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 7)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            health player = collision.GetComponent<health>();
            if (player != null)
            {
                player.TakeDamage(1);
            }

        }
        Instantiate(impact, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
