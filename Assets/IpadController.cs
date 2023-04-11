using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IpadController : MonoBehaviour
{
    public bool isGrabbed = false;
    public Transform grabPosition;
    public float grabDistance = 0.1f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
    }

    void Update()
    {
        if (isGrabbed)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            transform.position = grabPosition.position;
            transform.rotation = grabPosition.rotation;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            isGrabbed = true;
            rb.useGravity = false;
            rb.isKinematic = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            isGrabbed = false;
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }
}
