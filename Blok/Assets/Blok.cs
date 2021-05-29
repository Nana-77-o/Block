using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Blok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            Destroy(this.gameObject);
        }
        
    }
  
}
