using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
public GameObject[] BottomRooms; 
public GameObject[] TopRooms;
public GameObject[] LeftRooms;
public GameObject[] RightRooms;

public GameObject closedrooms;

public List<GameObject> rooms;
public float waittime;
private bool finalroom;
public GameObject end;
 public void Update()
 {
    if(waittime <= 0 && finalroom == false)
    {
     Instantiate(end, rooms[rooms.Count-1].transform.position, Quaternion.identity);   
     Debug.Log("wids");
     finalroom = true;
    }
    else
    {
        waittime -= Time.deltaTime;
        Debug.Log("sada");
    }
 } 
}
