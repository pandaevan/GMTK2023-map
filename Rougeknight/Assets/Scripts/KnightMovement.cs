using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class KnightMovement : MonoBehaviour
{
    public statsdegrade statsdegrade;
    private Vector2 direction;
    [SerializeField] Rigidbody2D rb;

    [Header("AnimationStuff")]
    [SerializeField] private SpriteRenderer Position;
    [SerializeField] private Animator Control;

    [Header("Movement")][SerializeField] float speed;

    //Audio
    [Header("Audio")][SerializeField] AudioSource audioSource;
    //SFX
    [Header("Audio")][SerializeField] AudioClip walking;



    private bool switchd;
    bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Called every frame
    private void Update()
    {
        InputsProcess();
        speed = statsdegrade.SPD * 3;
        if(speed == 0)
        {
            speed = 1;
        }
        DoAudio();
    }

    //Called a set amount per an update
    void FixedUpdate()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void InputsProcess() 
    {
        float Xmove = Input.GetAxisRaw("Horizontal");
        float Ymove = Input.GetAxisRaw("Vertical");

        if (Xmove > 0)
        {
            Position.flipX = true;
            Control.SetBool("IsRunning", true);
            isRunning = true;
            switchd = true;
        }
        else if (Xmove < 0)
        {
            Position.flipX = false;
            Control.SetBool("IsRunning", true);
            isRunning = true;
            switchd = false;
        }
        else if (Ymove > 0 || Ymove < 0)
        {
            if (switchd == false)
            {
                Position.flipX = false;
            }
            else
            {
                Position.flipX = true;
            } //I fucking hate this but not much I can do about it.

            Control.SetBool("IsRunning", true);
            isRunning = false;
        }
        else
        {
            Control.SetBool("IsRunning",false);
            isRunning = false;
            if (switchd == true)
            {
                Position.flipX = false;
            }
            else
            {
                Position.flipX = true;
            }
            //painful animation stuff because i'm too tired to flip the god damn scripts
        }

        direction = new Vector2(Xmove, Ymove).normalized;
    }
    void Movement() 
    {
        rb.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);
    }

    void DoAudio()
    {
        if (isRunning == true)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(walking);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

}
