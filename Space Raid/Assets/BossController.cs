using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public BossShooting bossShootingScript;
    public BulletRain bulletRainScript;
    public EnemyHealth EnemyHealthScript;
    private float enemyHealth;

    void Start()
    {
        StartCoroutine(BossBehavior());
    }

    private IEnumerator BossBehavior()
    {
        enemyHealth = EnemyHealthScript.GetHealth();
        while (true)
        {
            if (enemyHealth > 30)
            {
                bossShootingScript.enabled = true;
                bulletRainScript.enabled = false;
            }
            else
            {
                bossShootingScript.enabled = true;
                bossShootingScript.EnableChase(true);
                bulletRainScript.enabled = false;
            }

            yield return new WaitForSeconds(10.0f);

            bossShootingScript.enabled = false;
            bossShootingScript.EnableChase(false);
            yield return new WaitForSeconds(5.0f);

            bossShootingScript.enabled = false;
            bulletRainScript.enabled = true;

            yield return new WaitForSeconds(10.0f);

            bossShootingScript.enabled = false;
            bulletRainScript.enabled = false;

            yield return new WaitForSeconds(5.0f);
        }
    }
}