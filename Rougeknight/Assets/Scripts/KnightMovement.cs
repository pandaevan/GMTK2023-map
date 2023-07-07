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

        transform.Translate(htrans, vtrans, 0);
    } 
}
