using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class KnightCombat : MonoBehaviour
{
    [Header("Animation")]
    [SerializeField] private SpriteRenderer position;
    [SerializeField] private Animator control;


    //For attack's timing
    private float timeBtwAttack;
    public float startTimeBetweenAttack;

    //For attack's range
    public float range;

    //For modifications to attack
    public int damage;

    public float delay = 0.3f;
    private bool attackBlocked;

    public Transform circleOrigin;
    public float radius;

    public bool IsAttacking { get; private set; }

    public void ResetIsAttacking()
    {
        IsAttacking = false;
    }
    //Offset of weapon

    // Start is called before the first frame update
    void Start()
    {

    }

    private Vector2 pointerInput, movementInput;
    private void Update()
    {
        Vector2 pointerPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 direction = (pointerPosition - (Vector2)transform.position).normalized;


    }


    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Attack();
        }
    }

    public void Attack()
    {
        if (attackBlocked)
            return;

        control.SetTrigger("Attack");
        IsAttacking = true;
        attackBlocked = true;
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 position = circleOrigin == null ? Vector3.zero : circleOrigin.position;
        Gizmos.DrawWireSphere(position, radius);
    }

    private Vector2 GetPointerInput()
    {
        //Possible problem code
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    public void DetectColliders()
    {
        foreach (Collider2D collider in Physics2D.OverlapCircleAll(circleOrigin.position, radius))
        {
            Debug.Log(collider.tag);
        }
    }
}
