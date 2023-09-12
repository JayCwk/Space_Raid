using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private Animator anim;

    public Transform firePoint, firePoint1, firePoint2, firePoint3;
    private GameObject bullet;
    [SerializeField] private GameObject bullet1;
    [SerializeField] private GameObject bullet2;

    public bool splitFire = false;
    public bool backFire = false;
    public bool fireBullet = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(!bullet)
        {
            bullet = bullet1;
        }

        if(fireBullet == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if (bullet == bullet1)
                {
                    bullet = bullet2;
                }
                else if (bullet == bullet2)
                {
                    bullet = bullet1;
                }
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            anim.SetBool("shoot", true);
            if (splitFire == true)
            {
                SplitShoot();
            }
            if (backFire == true)
            {
                backShoot();
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
    void backShoot()
    {
        Instantiate(bullet, firePoint3.position, firePoint3.rotation);
    }
}
