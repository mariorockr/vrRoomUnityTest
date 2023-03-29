using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class XRSocketKnifeInteractor : XRSocketInteractor
{
    public List<GameObject> ObjectList;
    public string tagName;

    [SerializeField]
    public List<CheckCollisionWith> colliders;


    // Start is called before the first frame update
    private void Start()
    {
        foreach (CheckCollisionWith child in colliders)
        {
            child.collide = onCollide;
        }


        
    }

    void onCollide(Collider collider)
    {
        if (Singleton.instance.isRightHandInteracting)
        {
            if (isSelectActive)
            {
                IXRSelectInteractable objName = this.GetOldestInteractableSelected();
                if (objName != null) 
                {
                    Debug.Log("Collided");
                    for (int i = 0; i < ObjectList.Count; i++)
                    {
                        GameObject currentObj = ObjectList[i];
                        GameObject obj = Instantiate(ObjectList[i]);
                        obj.gameObject.SetActive(true);
                        obj.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.5f , this.transform.position.z);
                        obj.transform.localScale = currentObj.transform.lossyScale;
                        obj.GetComponent<Rigidbody>().velocity = obj.transform.up * 1;

                    }
                }


            }

        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

}
