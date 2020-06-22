﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMartillo : MonoBehaviour
{
    public GameObject martillo;    
    float velocidad = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        martillo = GameObject.Find("martillo");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

      public void derecha()
    {
        martillo.transform.localPosition += new Vector3(0f, 0f, 6f) * Time.deltaTime;
    }

    public void izquierda()
    {
        martillo.transform.localPosition -= new Vector3(0f, 0f, 6f)*   Time.deltaTime;
    }

    public void arriba()
    {
        martillo.transform.position -= transform.right * velocidad * Time.deltaTime;
    }

    public void abajo()
    {        
        martillo.transform.position += transform.right * velocidad * Time.deltaTime;
    }  
}
