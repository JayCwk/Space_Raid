using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private Animator anim;

    public Transform firePoint, firePoint1, firePoint2;
    public GameObject bullet;

    public bool setFire = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            anim.SetBool("shoot", true);
            if (setFire == true)
            {
                SplitShoot();
            }
        }
        else
        {
            anim.SetBool("shoot", false);
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    void SplitShoot()
    {
        Instantiate(bullet, firePoint1.position, firePoint1.rotation);
        Instantiate(bullet, firePoint2.position, firePoint2.rotation);
    }
}
