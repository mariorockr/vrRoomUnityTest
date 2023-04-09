using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionWith : MonoBehaviour
{
    public delegate void Collide(Collider collide);

    public Collide collide;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);

        if (other.gameObject.tag == "Knife")
        {
            collide(other);

        }

    }
     
}