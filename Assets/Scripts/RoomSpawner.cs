using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    // 1 -> need top door
    // 2 -> need left door
    // 3 -> need right door

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
    private GameObject mapicons;

    // Special room spawn tracking
    private static bool hasRecoveryRoom = false;
    private static bool hasItemRoom = false;
    private static bool hasShopRoom = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spawnpoint"))
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        mapicons = GameObject.FindGameObjectWithTag("Mapicons");
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.05f);
        if (templates.rooms.Count >= 10) // Replace 10 with your desired maximum
        {
            Destroy(gameObject);
            return;
        }
    }

    void Spawn()
    {
        if (!spawned)
        {
            GameObject roomToSpawn = null;

            // Chance to spawn a special room
            if (!hasRecoveryRoom && Random.Range(0f, 1f) < 0.1f) // 10% chance
            {
                roomToSpawn = templates.recoveryRoom; // Recovery Room
                hasRecoveryRoom = true;
            }
            else if (!hasItemRoom && Random.Range(0f, 1f) < 0.1f) // 10% chance
            {
                roomToSpawn = templates.itemRoom; // Item Room
                hasItemRoom = true;
            }
            else if (!hasShopRoom && Random.Range(0f, 1f) < 0.1f) // 10% chance
            {
                roomToSpawn = templates.shopRoom; // Shop Room
                hasShopRoom = true;
            }

            // If no special room is chosen, pick a regular room
            if (roomToSpawn == null)
            {
                if (openingDirection == 1) // Top door
                {
                    rand = Random.Range(0, templates.topRooms.Length);
                    roomToSpawn = templates.topRooms[rand];
                }
                else if (openingDirection == 2) // Left door
                {
                    rand = Random.Range(0, templates.leftRooms.Length);
                    roomToSpawn = templates.leftRooms[rand];
                }
                else if (openingDirection == 3) // Right door
                {
                    rand = Random.Range(0, templates.rightRooms.Length);
                    roomToSpawn = templates.rightRooms[rand];
                }
            }

            // Spawn the room
            Instantiate(roomToSpawn, transform.position, Quaternion.identity, mapicons.transform);

            spawned = true;
        }
    }
}
