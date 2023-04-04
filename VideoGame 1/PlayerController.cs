using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float Speed = 4;
    public float Jump = 10000;
    public Boolean OnGround = false;
    public int JumpCounter = 2;

    public Rigidbody2D body;
    private SpriteRenderer renderer;
    public Animator animator;
    private int maxJumps = 2;
    public Boolean canDoubleJump = false;
    private CircleCollider2D collider;
    public Boolean isDead = false;
    public Boolean win = false;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        collider = gameObject.AddComponent<CircleCollider2D>() as CircleCollider2D;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            isDead = true;
        }
        if (other.gameObject.tag == "Flag")
        {
            win = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            // Move Horizontal
            transform.Translate(new Vector2(Speed, 0));

            // Move vertical
            if (Input.GetButtonDown("Jump") && (OnGround == true))
            {
                body.AddForce(new Vector2(0, 12000));

                canDoubleJump = true;
            }

            // On spacebar press, double jump
            if ((canDoubleJump == true) && (OnGround == false))
            {
                if (Input.GetButtonDown("Jump") && (JumpCounter < maxJumps)) // Double Jump
                {
                    body.velocity = new Vector2(0, 0);
                    body.AddForce(new Vector2(0, 12000));
                    JumpCounter--;
                    canDoubleJump = false;
                }
            }

            if (OnGround)
            {
                JumpCounter = 1;
            }

            // Face the right direction
            //if (body.velocity.x < 0)
            //renderer.flipX = true;
            //else if (body.velocity.x > 0)
            //renderer.flipX = false;

            // Update animator parameters
            animator.SetBool("OnGround", OnGround);
            //animator.SetBool("Moving", body.velocity.x != 0);
            animator.SetFloat("VerticalVelocity", body.velocity.y);
            
        }
        else
        {
            Destroy(body);
            Destroy(renderer);
            //Destroy(animator);
            Destroy(collider);
        }

        if (win == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}