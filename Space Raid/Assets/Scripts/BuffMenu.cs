using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuffMenu : MonoBehaviour
{
    public GameObject buffMenu, buffMenu1;
    public GameObject buff, buff1;
    public Button fireBullet;
    public Button splitShot;
    public Button backFire;
    public Button invincible;
    public Button pierce;

    public PlayerWeapon weapon;
    public PlayerCtrl player;
    public health inc;
    public Bullet bullet;

    public void enableFireBullet()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().fireBullet = true;
        buffMenu.SetActive(false);
        buffMenu1.SetActive(false);
        Time.timeScale = 1;
        //player.gameObject.GetComponent<PlayerMove>().isPause = false;
    }
    public void enableSplitShot()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().splitFire = true;
        buffMenu.SetActive(false);
        buffMenu1.SetActive(false);
        Time.timeScale = 1;
        //player.gameObject.GetComponent<PlayerMove>().isPause = false;
    }
    public void enableInvincibility()
    {
        inc.gameObject.GetComponent<health>().invincibility = true;
        buffMenu.SetActive(false);
        buffMenu1.SetActive(false);
        Time.timeScale = 1;
    }
    public void enablePierce()
    {
        bullet.gameObject.GetComponent<Bullet>().setPierce = true;
        buffMenu.SetActive(false);
        buffMenu1.SetActive(false);
        Time.timeScale = 1;
    }
    public void enableBackFiret()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().backFire = true;
        buffMenu.SetActive(false);
        buffMenu1.SetActive(false);
        Time.timeScale = 1;
        //player.gameObject.GetComponent<PlayerMove>().isPause = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Buff"))
        {
            Time.timeScale = 0;
            //player.gameObject.GetComponent<PlayerMove>().isPause = true;
            buffMenu.SetActive(true);
            Destroy(buff);
        }
        else if (collision.gameObject.CompareTag("Buff1"))
        {
            Time.timeScale = 0;
            //player.gameObject.GetComponent<PlayerMove>().isPause = true;
            buffMenu1.SetActive(true);
            Destroy(buff1);
        }
        else if (collision.gameObject.CompareTag("Buff2"))
        {
            Time.timeScale = 0;
            //player.gameObject.GetComponent<PlayerMove>().isPause = true;
            buffMenu.SetActive(true);
            Destroy(buff);
        }
    }
}
