using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public int openingDirection;
    // 1 --> need bottom door
    // 2 --> need top door
    // 3 --> need left door
    // 4 --> need right door


    public RoomTemplates templates;
    private int rand;
    public bool spawned = false;

    public float waitTime = 4f;

    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    void Start()
    {
        Destroy(gameObject, waitTime);
        //templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }


    void Spawn()
    {
        if (spawned == false)
        {
            if (openingDirection == 1)
            {
                // Need to spawn a room with a BOTTOM door.
                int rand = 0; //Random.Range(0, bottomRooms.Length);
                Instantiate(bottomRooms[rand], transform.position, bottomRooms[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                // Need to spawn a room with a TOP door.
                int rand = 0; // Random.Range(0, topRooms.Length);
                Instantiate(topRooms[rand], transform.position, topRooms[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                // Need to spawn a room with a LEFT door.
                int rand = 0; //Random.Range(0, leftRooms.Length);
                Instantiate(leftRooms[rand], transform.position, leftRooms[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                // Need to spawn a room with a RIGHT door.
                int rand = 0; //Random.Range(0, rightRooms.Length);
                Instantiate(rightRooms[1], transform.position, rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                //Destroy(gameObject);
            }
            spawned = true;
        }
    }
}