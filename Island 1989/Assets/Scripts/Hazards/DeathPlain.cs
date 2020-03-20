using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlain : MonoBehaviour
{
    //The players spawn point
    [SerializeField] private Transform playerSpawn;

    //The player
    [SerializeField] private Transform player;

    //If the player collides with the death plain, they will respawn at the spawn point
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            player.transform.position = playerSpawn.transform.position;
        }
    }
}
