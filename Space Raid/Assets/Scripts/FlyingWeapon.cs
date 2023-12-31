using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingWeapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            timer = 0;
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, bulletPos.rotation);
    }
}
