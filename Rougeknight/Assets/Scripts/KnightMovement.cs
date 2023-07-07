using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;

    [Header("Movement")] [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    
    void FixedUpdate()
    {
        float htrans = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vtrans = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        switch (htrans) 
        {
            case > 0:
                rb.AddRelativeForce(Vector2.right * speed);
                break;
            case < 0:
                rb.AddRelativeForce(Vector2.left * speed);
                break;
        }
        switch (vtrans) 
        {
            case > 0:
                rb.AddRelativeForce(Vector2.up * speed);
                break;

            case < 0:
                rb.AddRelativeForce(Vector2.down * speed);
                break;
        }
    } 
    

    /*
    // Update is called every fixed framerate frame?
    void FixedUpdate()
    {
        float htrans = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vtrans = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(htrans, vtrans, 0);
    } */
}
