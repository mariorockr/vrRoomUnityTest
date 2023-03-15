using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObject : MonoBehaviour
{
    [SerializeField] GameObject emitter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Bullet")
        {

            GameObject particles = Instantiate(emitter);
            particles.gameObject.SetActive(true);
            particles.transform.position = emitter.transform.position;
            Destroy(particles, 5);
 
        }
 
    }
}
