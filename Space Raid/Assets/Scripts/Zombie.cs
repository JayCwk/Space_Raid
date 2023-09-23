using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private AudioClip zombie;
    private GameObject player;

    private bool enemyColl;
    public Transform enemyCheck;
    public LayerMask isEnemy;
    private bool atEdge;
    public Transform edgeCheck;
    public float edgeCheckRadius;
    public LayerMask whatIsEdge;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        soundmanager.instance.PlaySound(zombie);
    }

    void Update()
    {
        atEdge = Physics2D.OverlapCircle(edgeCheck.position, edgeCheckRadius, whatIsEdge);
        enemyColl = Physics2D.OverlapCircle(enemyCheck.position, edgeCheckRadius, isEnemy);

        


        if (atEdge && !enemyColl)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
           
        }

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
