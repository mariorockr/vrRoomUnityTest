using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    public GameObject displayObject;

    void Start()
    {
        displayObject.SetActive(false);
    }

    void Update()
    {
        if (transform.parent != null && transform.parent.CompareTag("Hand"))
        {
            displayObject.SetActive(true);
        }
        else
        {
            displayObject.SetActive(false);
        }
    }
}
