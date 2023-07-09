using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addrooms : MonoBehaviour
{
private RoomTemplates templates;
void Start()
    {
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    templates.rooms.Add(this.gameObject);
    }
}
