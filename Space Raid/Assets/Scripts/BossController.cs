using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public BossShooting bossShootingScript;
    public BulletRain bulletRainScript;
    public EnemyHealth EnemyHealthScript;
    

    void Start()
    {
        StartCoroutine(BossBehavior());
    }

    private IEnumerator BossBehavior()
    {
        while (true)
        {
            
            float enemyHealth = EnemyHealthScript.GetHealth();

            if (enemyHealth > 30)
            {
                bossShootingScript.enabled = true;

                yield return new WaitForSeconds(10.0f);

                bossShootingScript.enabled = false;

                yield return new WaitForSeconds(5.0f);

            }
            else
            {
                bossShootingScript.enabled = true;
                bulletRainScript.enabled = false;

                yield return new WaitForSeconds(10.0f);

                bossShootingScript.enabled = false;
                bulletRainScript.enabled = false;

                yield return new WaitForSeconds(5.0f);

                bossShootingScript.enabled = false;
                bulletRainScript.enabled = true;

                yield return new WaitForSeconds(10.0f);

                bossShootingScript.enabled = false;
                bulletRainScript.enabled = false;

                yield return new WaitForSeconds(5.0f);
            }

            
            yield return new WaitForSeconds(1.0f);
        }
    }

}