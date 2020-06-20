using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausaEntrePuntajesTRES : MonoBehaviour
{
    public almacenaPuntajesTRES puntajes;
    public GameObject objetoPuntaje;
    float secondsCounter;    
    public GameObject pasarJug;
    // Start is called before the first frame update
    void Start()
    {
        objetoPuntaje = GameObject.Find("objetoPuntaje");
        puntajes = objetoPuntaje.GetComponent<almacenaPuntajesTRES>();
        secondsCounter = 0;        
        pasarJug = GameObject.FindWithTag("PASAR");                      
        pasarJug.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
         if(pasarJug==null)
        {
            pasarJug = GameObject.FindWithTag("PASAR");    
        }            
        Debug.Log("1:" + puntajes.jugador1 + ", 2:" + puntajes.jugador2 + ", 3:" + puntajes.jugador3);
        if (puntajes.jugador1 != 0 && puntajes.turno==2)
        {          
            Debug.Log("ENTRA 1");
              metodoEspera(3);      
             pasarJug.SetActive(true);
        }

        else if (puntajes.jugador2 != 0 && puntajes.turno==3)
        {
              Debug.Log("ENTRA 2");
              metodoEspera(4);     
              pasarJug.SetActive(true);
        }       
        
        else if(puntajes.jugador3 != 0  && puntajes.turno==4)
        {
            Debug.Log("ENTRA 3");
            metodoEspera(0); 
        }
    }

    void metodoEspera(int turno)
    {
        secondsCounter += Time.deltaTime;
                
                if (secondsCounter>7 && secondsCounter < 7.1)
                {       
                    secondsCounter=0;
                    puntajes.turno=turno;
                     if(turno!=0)
                     {
                      SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
                     }
                                       
                }                      
    }
}
