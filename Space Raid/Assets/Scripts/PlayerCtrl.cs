using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    //[SerializeField] private LayerMask jumpableGround;

    private float dirX = 0f;
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MoveState { idle, running, jumping, falling }

    //[SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            //jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        MoveState state;

        if (dirX > 0f)
        {
            state = MoveState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MoveState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MoveState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MoveState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MoveState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    /*private bool OnGround()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }*/
}
