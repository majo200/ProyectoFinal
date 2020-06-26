using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausaEntrePuntajesTRES : MonoBehaviour
{
    //ESTE CÓDIGO ES PARA LA ESPERA ENTRE JUGADORES (3)

    //Objeto y código que almacena puntajes 
    public almacenaPuntajesTRES puntajes;
    public GameObject objetoPuntaje;

    //Esta variable se utilizará para la espera
    float secondsCounter;    

    //Texto que indica el turno del siguiente jugador
    public GameObject pasarJug;
    
    void Start()
    {
        //Encontramos los objetos y códigos
        objetoPuntaje = GameObject.Find("objetoPuntaje");
        puntajes = objetoPuntaje.GetComponent<almacenaPuntajesTRES>();
        secondsCounter = 0;        
        pasarJug = GameObject.FindWithTag("PASAR");      
        //Desactivamos el texto que indica el siguiente jugador
        pasarJug.SetActive(false);
    }

    
    void Update()
    {
        //Verificamos que los objetos hayan sido encontrados
        if (pasarJug == null)
        {
            pasarJug = GameObject.FindWithTag("PASAR");
        }
        if (objetoPuntaje == null)
        {
            objetoPuntaje = GameObject.Find("objetoPuntaje");
        }
        if (puntajes == null)
        {
            puntajes = objetoPuntaje.GetComponent<almacenaPuntajesTRES>();
        }

        //Muestra en consola los 3 puntajes
        Debug.Log("1:" + puntajes.jugador1 + ", 2:" + puntajes.jugador2 + ", 3:" + puntajes.jugador3);

        //Si el jugador 1 ya tiene un puntaje almacenado, y el turno es el 2
        if (puntajes.jugador1 != 0 && puntajes.turno==2)
        {          
              Debug.Log("ENTRA 1");
              //Ejecute el método, enviándole el turno=3
              metodoEspera(3);      
              //Active el texto del siguiente jugador
              pasarJug.SetActive(true);
        }

        //Si el jugador 2 ya tiene un puntaje almacenado, y el turno es el 3
        else if (puntajes.jugador2 != 0 && puntajes.turno==3)
        {
              Debug.Log("ENTRA 2");
              //Ejecute el método, enviándole el turno 4 
              metodoEspera(4);     
              //Active el texto del siguiente jugador
              pasarJug.SetActive(true);
        }       
        
        //Si el jugador 3 ya tiene almacenado un puntaje, y el turno es el 4
        else if(puntajes.jugador3 != 0  && puntajes.turno==4)
        {
            Debug.Log("ENTRA 3");
            //Ejecute el método, enviandole el turno 0
            metodoEspera(0); 
            //Como es el último jugador, ya no se carga el texto de siguiente jugador, sino el calculando ganador
        }
    }

    //Método de espera
    void metodoEspera(int turno)
    {
        secondsCounter += Time.deltaTime;
                
                //Si ya pasaron alrededor de 7 segundos
                if (secondsCounter>7 )
                {       
                    secondsCounter=0;
                    //Almacene en el codigo de turnos el valor pasado arriba
                    puntajes.turno=turno;
                    
                     //Si el turno es diferente de cero, recargue la escena 
                     if(turno!=0)
                     {
                      SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
                     }
                                       
                }                      
    }
}
