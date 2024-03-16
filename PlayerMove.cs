using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    public float jumpp = 15f;
    private Rigidbody2D rb;
    public GameObject OptionCall;
    public GameObject objectToToggle;
    private bool isJumping;
    private Animator anim;
    private SpriteRenderer sprite;
    private float horizontal=0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();
        Jump();
        pauseGameSpace();
    }

    void MovePlayer()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontal*speed, rb.velocity.y);
        UpdateAnimationUpdate();
    }
    private void UpdateAnimationUpdate()
    {

        if (horizontal > 0f)
        {
            anim.SetBool("Running", true);
            sprite.flipX = false;
        }
        else if (horizontal < 0f)
        {
            anim.SetBool("Running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpp);
            isJumping = true; 
        }
    }
    void pauseGameSpace()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            OptionCall.SetActive(!OptionCall.activeSelf);
            if (objectToToggle != null)
            {
                objectToToggle.SetActive(false);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    
}
