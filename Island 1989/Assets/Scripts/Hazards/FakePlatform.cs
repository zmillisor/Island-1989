using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlatform : MonoBehaviour
{
    //The Faker
    [SerializeField] private GameObject fakePlatform;

    //If the player steps on the fake platform, it is set to false
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            fakePlatform.SetActive(false);
        }
    }
}
