using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] Rigidbody2D rb;

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

        direction = new Vector2(Xmove, Ymove).normalized;
    }
    void Movement() 
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
