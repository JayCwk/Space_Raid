using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeMob : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (transform.position.x > player.transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (transform.position.x < player.transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

}
