using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumeable_Status : MonoBehaviour
{
    private statsdegrade Stat;
    [SerializeField] private float amp;
    [SerializeField] private Transform body;
    [SerializeField] private string Tag;

    private float SetPosition;

    void Start()
    {
        SetPosition = body.position.y;

    }
    void Update()
    {
        float Sine = Mathf.Sin(Time.time)*amp + SetPosition;
        body.position = new Vector3(body.position.x, Sine, body.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch(Tag)
        {
            case "Armor":
                Debug.Log("Armor");
                break;
            case "Health":
                Debug.Log("Health");
                break;
            case "Sword":
                Debug.Log("Sword");
                break;
            case "Shield":
                Debug.Log("Shield");
                break;
        }

        Destroy(gameObject);
    }
}
