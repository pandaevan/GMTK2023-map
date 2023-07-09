using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    [SerializeField] private float offset = 0.5f;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void circleOffset(bool onX) 
    {
        if (onX == true) 
        {
            transform.position.x += offset;
        }
        else 
        {
            transform.position.y += offset;
        }
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
    } */
}
