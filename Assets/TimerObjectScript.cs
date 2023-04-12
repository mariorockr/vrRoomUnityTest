using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isColliding = false;

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            print("Colisionando");
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pizza") {
            isColliding = true;
            print("Entro");
        }
       

    }


    void OnCollisionExit(Collision other)
    {
        isColliding = false;
        print("Salio");


    }
}
