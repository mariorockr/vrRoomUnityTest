using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{

    public GameObject leftGrabRay;
    public GameObject rightGrabRay;

    public XRDirectInteractor leftInteractorGrab;
    public XRDirectInteractor rightInteractorGrab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftGrabRay.SetActive(leftInteractorGrab.interactablesSelected.Count == 0);
        rightGrabRay.SetActive(rightInteractorGrab.interactablesSelected.Count == 0);
        
    }
}
