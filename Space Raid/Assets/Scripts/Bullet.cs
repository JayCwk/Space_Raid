using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1;
    public Rigidbody2D rb;
    public GameObject impact;

    public bool setPierce = false;
    public int pierce = 1;

    private float timer;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (setPierce == true)
        {
            EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.takeDamage(damage);
            }

            if (pierce > 1)
            {
                Instantiate(impact, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            pierce++;
        }
        else
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
}
