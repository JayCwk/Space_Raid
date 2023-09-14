using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("iFrames")]
    [SerializeField] private float iFrameDuration;
    [SerializeField] private int numberOffSlashes;
    private SpriteRenderer spriteRend;

    [SerializeField] private Behaviour[] components;
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioClip hurtSound;

    public bool invincibility = false;

    public PlayerWeapon resetInc;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
        spriteRend = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float _damage)
    {
        if (invincibility == true)
        {
            invincibility = false;
            resetInc.gameObject.GetComponent<PlayerWeapon>().invincibilityCD = true;
            return;
        }
        else
        {
            currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

            if (currentHealth > 0)
            {
                StartCoroutine(Invunerability());
                soundManager.instance.PlaySound(hurtSound);
            }
            else
            {
                if (!dead)
                {
                    anim.SetTrigger("die");

                    if (GetComponent<PlayerCtrl>() != null)
                        GetComponent<PlayerCtrl>().enabled = false;



                    foreach (Behaviour component in components)
                        component.enabled = false;

                    dead = true;
                    soundManager.instance.PlaySound(deathSound);
                    SceneManager.LoadScene("Game Over");
                }
            }
        }

        
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private IEnumerator Invunerability()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);

        for (int i = 0; i < numberOffSlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFrameDuration / (numberOffSlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFrameDuration / (numberOffSlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
