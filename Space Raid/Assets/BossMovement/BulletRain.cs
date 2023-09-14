using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRain : MonoBehaviour
{
    public GameObject bossbulletPrefab;
    public List<Transform> bulletPositions;
    private float bulletLifetime = 10.0f;
    private float bulletSpeed = 10.0f; 

    void Start()
    {
        StartCoroutine(AttackCycle());
    }

    private IEnumerator AttackCycle()
    {
        int bulletsShot = 0;

        while (bulletsShot < 10)
        {
            ShootBullets();
            bulletsShot++;
            yield return new WaitForSeconds(1.0f);
        }

        yield return new WaitForSeconds(5.0f);

        bulletsShot = 0;
    }

    private void ShootBullets()
    {
        foreach (Transform bulletPosition in bulletPositions)
        {
            shootBossBullet(bulletPosition);
        }
    }

    void shootBossBullet(Transform bulletPosition)
    {
        GameObject bossbullet = Instantiate(bossbulletPrefab, bulletPosition.position, bulletPosition.rotation);

        Rigidbody2D bulletRb = bossbullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = bossbullet.transform.up * bulletSpeed;

        Destroy(bossbullet, bulletLifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {

    }
}
