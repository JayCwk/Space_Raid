using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMob : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private GameObject player;
    private float timer;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (transform.position.x > player.transform.position.x)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (transform.position.x < player.transform.position.x)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        timer += Time.deltaTime;
        if (timer > 10)
        {
            timer = 0;
            Remove();
        }
    }
    private void Remove()
    {
        Destroy(gameObject);
    }
}
