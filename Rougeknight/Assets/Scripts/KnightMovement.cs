using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 moveinput;
    [SerializeField] Rigidbody2D rb;

    float hmove;
    float vmove;

    [Header("Movement")] [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveinput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveinput = Vector2.ClampMagnitude(moveinput * speed, speed);
    }


    void FixedUpdate()
    {
        transform.Translate(moveinput.x * Time.fixedDeltaTime, moveinput.y * Time.fixedDeltaTime, 0);
    }
}
