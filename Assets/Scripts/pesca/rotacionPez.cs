using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionPez : MonoBehaviour
{
    
    public GameObject peces;
   
    void Start()
    {
        peces = GameObject.Find("Peces");
    }

   
    void Update()
    {
        peces.transform.Rotate(0.0f, 2.0f, 0.0f, Space.Self);
    }
}
