using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEditorScript1 : MonoBehaviour
{
    public GameObject bossbulletPrefab;
    public Transform bulletPosition1;
    public Transform bulletPosition2;
    public Transform bulletPosition3;
    public Transform bulletPosition4;
    public Transform bulletPosition5;
    public Transform bulletPosition6;
    public Transform bulletPosition7;
    public Transform bulletPosition8;

    private float timer = 10;
    void Start()
    {
        StartCoroutine(BossShoot());
    }

    private IEnumerator BossShoot()
    {
        while (true)
        {
            shoot();
            yield return new WaitForSeconds(2); 
        }
    }

   

    private void shoot()
    {
        shootBossBullet(bulletPosition1);
        shootBossBullet(bulletPosition2);
        shootBossBullet(bulletPosition3);
        shootBossBullet(bulletPosition4);
        shootBossBullet(bulletPosition5);
        shootBossBullet(bulletPosition6);
        shootBossBullet(bulletPosition7);
        shootBossBullet(bulletPosition8);
    }

    void shootBossBullet(Transform bulletPosition)
    {
        GameObject bullet = Instantiate(bossbulletPrefab, bulletPosition.position, bulletPosition.rotation);


        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.velocity = bullet.transform.up * timer;
    }

    
}

