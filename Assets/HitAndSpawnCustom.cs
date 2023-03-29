using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAndSpawnCustom : MonoBehaviour
{
    public List<GameObject> ObjectList;
    public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ObjectList.Count; i++)
        {
            GameObject currentObj = ObjectList[i];
            currentObj.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == tagName)
        {
              if (ObjectList.Count > 0)
              {
                  for (int i = 0; i < ObjectList.Count; i++)
                  {
                      GameObject currentObj = ObjectList[i];
                      GameObject obj = Instantiate(ObjectList[i]);
                      obj.gameObject.SetActive(true);
                      obj.transform.position = this.transform.position;
                      obj.transform.localScale = currentObj.transform.lossyScale;
                  }

                 // Destroy(this.gameObject, 0.05f);

              }

            print("Hit");
        }

    }
}
