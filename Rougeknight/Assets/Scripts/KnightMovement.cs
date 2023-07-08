using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class KnightMovement : MonoBehaviour
{
    public statsdegrade statsdegrade;
    private Vector2 direction;
    [SerializeField] Rigidbody2D rb;

    [Header("AnimationStuff")]
    [SerializeField] private SpriteRenderer Position;
    [SerializeField] private Animator Control;

    [Header("Movement")][SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Called every frame
    private void Update()
    {
        InputsProcess();
        speed = statsdegrade.SPD/5;
        if(speed == 0)
        {
            speed = 1;
        }
    }

    //Called a set amount per an update
    void FixedUpdate()
    {
        Movement();
    }

    void InputsProcess() 
    {
        float Xmove = Input.GetAxisRaw("Horizontal");
        float Ymove = Input.GetAxisRaw("Vertical");

        if (Xmove > 0)
        {
            Position.flipX = true;
            Control.SetBool("IsRunning", true);
        }
        else if (Xmove < 0)
        {
            Position.flipX = false;
            Control.SetBool("IsRunning", true);
        }
        else if (Ymove > 0 || Ymove < 0)
        {
            Control.SetBool("IsRunning", true);
        }
        else
        {
            Control.SetBool("IsRunning",false);
        }

        direction = new Vector2(Xmove, Ymove).normalized;
    }
    void Movement() 
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
