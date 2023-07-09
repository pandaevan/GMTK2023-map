using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoints : MonoBehaviour
{
    public int OpeningDirection;
    //1 needs a bottom opening
    //2 needs a top opening
    //3 needs a left opening
    //4 needs a right opening
private RoomTemplates templates;
private int rand;
private bool spawned = false;
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn" , 0.1f);
        Invoke("rescans",6f);
    }

    // Update is called once per frame
    void Spawn()
    {
        if(spawned == false)
        {
        if(OpeningDirection == 1)
        {
            rand = Random.Range(0, templates.BottomRooms.Length);
            Instantiate(templates.BottomRooms[rand], transform.position, templates.BottomRooms[rand].transform.rotation);

        }
                if(OpeningDirection == 2)
        {
rand = Random.Range(0, templates.TopRooms.Length);
            Instantiate(templates.TopRooms[rand], transform.position, templates.TopRooms[rand].transform.rotation);
        }
                if(OpeningDirection == 3)
        {
rand = Random.Range(0, templates.LeftRooms.Length);
            Instantiate(templates.LeftRooms[rand], transform.position, templates.LeftRooms[rand].transform.rotation);
        }
                if(OpeningDirection == 4)
        {
rand = Random.Range(0, templates.RightRooms.Length);
            Instantiate(templates.RightRooms[rand], transform.position, templates.RightRooms[rand].transform.rotation);
        }
        spawned = true;
        }

    }
        void Update() 
        {

        }
        void rescans()
        {
            AstarPath.active.Scan();
        }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("spawnpoint"))
        {
            if (other.GetComponent<spawnpoints>().spawned == false && spawned == false)
            {
            Instantiate(templates.closedrooms, transform.position, Quaternion.identity);
            Destroy(gameObject);
            }
            spawned = true;
        }
    }
}
