using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionTRES : MonoBehaviour
{
    public int puntaje;
    public Text textoPuntaje;   
    public tiempo codigoTiempo;
    public almacenaPuntajesTRES puntajesC;
    public GameObject pasarJug;    
    public GameObject martillo;
    void Start()
    {
        puntaje = 0;
        puntajesC = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajesTRES>();
        codigoTiempo= GameObject.Find("tiempo").GetComponent<tiempo>();   
        pasarJug = GameObject.FindWithTag("PASAR"); 
        pasarJug.SetActive(false);         
        martillo = GameObject.Find("martillo");
        martillo.SetActive(true);
        
    }
    void OnTriggerEnter(Collider other)
    {
        //Output the Collider's GameObject's name
        Debug.Log("Se le pegó al topo");
        puntaje++;
        textoPuntaje.text = puntaje.ToString();

    }

    void Update()
    {
         if(pasarJug==null)
         {
            pasarJug = GameObject.FindWithTag("PASAR");    
         }  
        

         if(puntajesC==null)
         {
            puntajesC = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajesTRES>();
         }

        if (codigoTiempo.reloj==0)
        {       
            if (puntajesC.jugador1 == 0)
            {
               puntajesC.jugador1 = puntaje;
               pasarJug.SetActive(true);  
               martillo.SetActive(false);
            }
            else if(puntajesC.jugador2 == 0)
            {
                puntajesC.jugador2 = puntaje;               
                pasarJug.SetActive(true);  
                martillo.SetActive(false);               
            } 
             else if(puntajesC.jugador3 == 0)
            {
                puntajesC.jugador3 = puntaje;                      
                martillo.SetActive(false);               
            } 
        }       
    }
}
