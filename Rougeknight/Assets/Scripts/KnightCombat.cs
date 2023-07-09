using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class KnightCombat : MonoBehaviour
{
    //Use mouse for aim; direction player faces
    //Playerinput: mouse click
    //Player mouse indicates slash?

    private Transform empty;
    public Transform knight;

    //Note: GetComponent is get gameObjects from other objects in the scene (i.e. script is not assigned to)
    Vector2 direction;

    //For attack's timing
    private float timeBtwAttack;
    public float startTimeBetweenAttack;

    //For attack's range
    public float attackRange;

    //For modifications to attack
    public int damage;

    public float offset = 0.5f;
    // public LayerMask;


    //Offset of weapon

    // Start is called before the first frame update
    void Start()
    {
    }
    //Create an empty, throw in front of player
    //Raycast?
    //Compare tags

    void FixedUpdate()
    {
        InputsProcess();

        // RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(direction), attackRange);


        //Is key pressed?
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //Did they just attack less than a second ago?
            if (timeBtwAttack <= 0)
            {
                timeBtwAttack = startTimeBetweenAttack;

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(transform.position, attackRange);

                int i;
                for (i = 0; i < enemiesToDamage.Length; i++)
                {
                    Debug.Log(enemiesToDamage[i].gameObject.name);
                }

                for (i = 0; i < enemiesToDamage.Length; i++)
                {
                    Debug.Log(enemiesToDamage[i].gameObject.name);
                    if (enemiesToDamage[i].tag == "Enemy")
                    {
                        Debug.Log("HIT EPIC HIT");
                    }
                }
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
        }

        /*if (hit.collider.gameObject.CompareTag("Enemy")) 
        {
            hit.collider.gameObject.GetComponent<SlimeCombat>().TakeDamage(damage);
        }
        else 
        {

        } */

        // Debug.DrawRay(transform.position, transform.TransformDirection(direction * attackRange), Color.white);
    }

    void InputsProcess()
    {
        float Xmove = Input.GetAxisRaw("Horizontal");
        float Ymove = Input.GetAxisRaw("Vertical");

        if (Xmove > 0)
        {
            direction = Vector2.right;
            transform.position = new Vector2(knight.transform.position.x + 0.5f, knight.transform.position.y);
        }
        else if (Xmove < 0)
        {
            direction = Vector2.left;
            transform.position = new Vector2(knight.transform.position.x - 0.5f, knight.transform.position.y);
        }
        else if (Ymove > 0)
        {
            direction = Vector2.up;
            transform.position = new Vector2(knight.transform.position.x, knight.transform.position.y + 0.5f);
        }
        else if (Ymove < 0)
        {
            direction = Vector2.down;
            transform.position = new Vector2(knight.transform.position.x, knight.transform.position.y - 0.5f);
        }
    }
}

/*
 *   Ray ray = new Ray(transform.position, Input.mousePosition.normalized);
        transform.position = knight.position;

        Vector2 vec = new Vector2(Input.mousePosition.x - transform.position.x, Input.mousePosition.y - transform.position.y);

        ;
        Debug.DrawRay(transform.position, vec.normalized, Color.magenta);

        void CheckForColliders()
        { }
 * 
 */

// Update is called once per frame
/*  void Update()
  {
      attackPos.position = transform.position;


      if (Input.GetMouseButtonDown(0) == true) 
      {
          Debug.Log("Mouseclick");

          if (timeBtwAttack <= 0) 
          {
              timeBtwAttack = startTimeBetweenAttack;

              Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange);

              int i;
              for (i = 0; i < enemiesToDamage.Length; i++)
              {
                  Debug.Log(enemiesToDamage[i].gameObject.name);
              }

              for (i = 0; i < enemiesToDamage.Length; i++) 
              {
                  if (enemiesToDamage[i].tag == "Enemy") 
                  {

                  }
                  Debug.Log("HIT EPIC HIT");
              }
          } 
          else 
          {
              timeBtwAttack -= Time.deltaTime;
          }
      }

  } */