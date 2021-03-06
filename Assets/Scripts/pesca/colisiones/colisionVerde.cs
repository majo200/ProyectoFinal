﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionVerde : MonoBehaviour
{
    public almacenaPuntajes puntajes;
    public GameObject objetoPuntaje;
    public int verdes;
    public int otros;
    public int final;
    public GameObject pez;
    public GameObject cañaVerde;
    public Text textoPuntaje;
    public Text textoMISMO;
    public Text textoOTRO;   

    void Start()
    {
        verdes = 0;
        otros = 0;
        final = 0;
        cañaVerde = GameObject.Find("CañaVerde");
        objetoPuntaje= GameObject.Find("objetoPuntaje");
        puntajes= objetoPuntaje.GetComponent<almacenaPuntajes>();
    }
    void OnTriggerEnter(Collider other)
    {
        //Output the Collider's GameObject's name
        Debug.Log("Pez Atrapado" + "\n");
        pez = other.gameObject;
        pez.SetActive(false);

        if (pez.tag=="Verde")
        {
            verdes+=2;
            textoMISMO.text = verdes.ToString();
        }
           

        else
        {
            otros+=3;
            textoOTRO.text = otros.ToString();
        }

        
    }
    void Update()
    {
        
        if (verdes == 14)
        {
            final = verdes - otros;
            textoPuntaje.text = final.ToString();
            cañaVerde.SetActive(false);            
            if(puntajes.jugador1==0)
            {  
                puntajes.jugador1= final;                   
            }
            else 
            {
                puntajes.jugador2= final;
            }
           
        }
    }
}
