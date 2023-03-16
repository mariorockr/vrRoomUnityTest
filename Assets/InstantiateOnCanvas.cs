using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnCanvas : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;
    public GameObject gameObject3;


    private GameObject selectedGameObject;

    private void Start()
    {
        selectedGameObject = gameObject;
    }

    public void selectGameObject(int index)
    {
        switch (index)
        {
            case 0:
                selectedGameObject = gameObject;
                break;
                case 1:
                selectedGameObject = gameObject2;
                break;
            case 2:
                selectedGameObject = gameObject3;
                break;
        }
    }
    public void instantiateGameObject()
    {
        GameObject spawn = Instantiate(selectedGameObject);
        spawn.transform.position = new Vector3(0, 0, 0);
        spawn.transform.rotation = Quaternion.identity;
     }
   
}
