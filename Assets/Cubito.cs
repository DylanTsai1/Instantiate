using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour
{  
 public GameObject objectClone; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instantiate()
    {
        int i = 0;
        while(i<3)
        Instantiate(objectClone);
        i++; 
        

    }
}
