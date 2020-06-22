using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pescaCodigo : MonoBehaviour
{
    //GameObject que tiene los peces 
    public GameObject peces;

    void Start()
    {
       //Encuentra el objeto de peces 
       peces = GameObject.Find("Peces");
       
    }

    // Update is called once per frame
    void Update()
    {
        //Rota a todos los peces
        peces.transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);    
    }
}
