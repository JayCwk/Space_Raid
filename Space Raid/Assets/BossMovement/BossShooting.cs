using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public GameObject bossbullet;
    public Transform bulletPos;
    public float bulletLifetime = 10.0f;
    public float bulletSpeed;
    private float timer;
    private bool isChasing = false;
    public float chaseSpeed;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            ShootInAllDirections();
        }

        if (isChasing)
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * chaseSpeed * Time.deltaTime;
        }
    }
    void ShootInDirection(Vector2 direction)
    {
        GameObject bullet = Instantiate(bossbullet, bulletPos.position, Quaternion.identity);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = direction.normalized * bulletSpeed;
        Destroy(bullet, bulletLifetime);
    }

    void ShootInAllDirections()
    {
        Vector2[] directions = {
            Vector2.left,
            Vector2.right,
            Vector2.up,
            Vector2.down,
            (Vector2.up + Vector2.left).normalized,
            (Vector2.up + Vector2.right).normalized,
            (Vector2.down + Vector2.left).normalized,
            (Vector2.down + Vector2.right).normalized
        };

        foreach (Vector2 direction in directions)
        {
            ShootInDirection(direction);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    public void EnableChase(bool enable)
    {
        isChasing = enable;
    }
}
