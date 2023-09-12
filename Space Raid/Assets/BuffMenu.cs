using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuffMenu : MonoBehaviour
{
    public GameObject buffMenu;
    public GameObject buff;
    public Button fireBullet;
    public Button splitShot;
    public Button backFire;

    public PlayerWeapon weapon;
    public PlayerCtrl player;

    public void enableFireBullet()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().fireBullet = true;
        buffMenu.SetActive(false);
        Time.timeScale = 1;
        //player.gameObject.GetComponent<PlayerMove>().isPause = false;
    }
    public void enableSplitShot()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().splitFire = true;
        buffMenu.SetActive(false);
        Time.timeScale = 1;
        //player.gameObject.GetComponent<PlayerMove>().isPause = false;
    }
    public void enableBackFiret()
    {
        weapon.gameObject.GetComponent<PlayerWeapon>().backFire = true;
        buffMenu.SetActive(false);
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
    }
}
