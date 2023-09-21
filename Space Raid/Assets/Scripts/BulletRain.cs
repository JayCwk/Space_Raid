using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRain : MonoBehaviour
{
    public GameObject bossbulletPrefab;
    public List<Transform> bulletPositions;
    private float bulletLifetime = 10.0f;
    private float bulletSpeed = 10.0f;
    private float timer = 0;

    void Start()
    {
        
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

   

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            ShootBullets();
        }
    }
}
