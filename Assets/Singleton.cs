using UnityEngine;
using UnityEngine.InputSystem;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;

    public InputActionProperty leftPinch;
    public InputActionProperty leftGrip;

    public InputActionProperty rightPinch;
    public InputActionProperty rightGrip;




    [HideInInspector]
    public bool isLeftHandInteracting;

    [HideInInspector]
    public bool isRightHandInteracting;

    private void Awake()
    {
        CreateSingleton();
    }

    void CreateSingleton()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (leftPinch.action.ReadValue<float>() > 0 || leftGrip.action.ReadValue<float>() > 0)
        {
            isLeftHandInteracting = true;
        } else
        {
            isLeftHandInteracting = false;
        }

        if (rightPinch.action.ReadValue<float>() > 0 || rightGrip.action.ReadValue<float>() > 0)
        {
            isRightHandInteracting = true;
        }
        else
        {
            isRightHandInteracting = false;
        }


    }
}