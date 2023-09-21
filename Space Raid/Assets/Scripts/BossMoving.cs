using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoving : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (transform.position.x > player.transform.position.x)
        {
            transform.localScale = new Vector3(7, 6, 1);
        }
        if (transform.position.x < player.transform.position.x)
        {
            transform.localScale = new Vector3(-7, 6, 1);
        }
    }
}
