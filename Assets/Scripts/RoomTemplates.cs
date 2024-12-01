using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject recoveryRoom; // Recovery Room prefab
    public GameObject itemRoom;     // Item Room prefab
    public GameObject shopRoom;     // Shop Room prefab

    
    private GameObject mapicons;

    public GameObject bossRoom; // Boss room prefab
    public List<GameObject> rooms;

    private bool bossSpawned = false;

    void Start()
    {
        mapicons = GameObject.FindGameObjectWithTag("Mapicons");
    }
    void Update()
    {
        // Check if all rooms are spawned (you may need to adjust timing based on your game)
        if (!bossSpawned && rooms.Count > 0)
        {
            StartCoroutine(SpawnBossRoom());
        }
    }

    IEnumerator SpawnBossRoom()
    {
        yield return new WaitForSeconds(1.0f); // Wait for all rooms to finish spawning
        if (rooms.Count > 0 && !bossSpawned)
        {
            // Clean up the rooms list to remove any destroyed objects
            rooms.RemoveAll(room => room == null);

            if (rooms.Count > 0)
            {
                // Replace the last valid room with the boss room
                GameObject lastRoom = rooms[rooms.Count - 1];
                Vector3 bossRoomPosition = lastRoom.transform.position;

                // Destroy the last room
                Destroy(lastRoom);

                // Spawn the boss room at its position
                Instantiate(bossRoom, bossRoomPosition, Quaternion.identity, mapicons.transform);

                bossSpawned = true;
            }
        }
    }

}