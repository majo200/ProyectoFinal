using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionAmarilloTRES : MonoBehaviour
{
    //PARA LA CAÑA AMARILLA
    //ESTE MÉTODO ES IGUAL PARA LAS OTRAS CAÑAS
    //Código y objeto de puntajes
    public almacenaPuntajesTRES puntajes;
    public GameObject objetoPuntaje;

    //Variables que almacenarán la cantidad de peces que se atrapen
    public int amarillos;
    public int otros;
    public int final;

    //GameObject del pez y la caña amarilla
    public GameObject pez;
    public GameObject cañaAmarilla;

    //Textos que mostrarán el puntaje por atrapar los peces del mismo y de diferente color, y el puntaje final
    public Text textoPuntaje;
    public Text textoMISMO;
    public Text textoOTRO;
    
    void Start()
    {
        //Al inicio todos  son cero
        amarillos = 0;
        otros = 0;
        final = 0;

        //Encontramos la caña, el objeto puntaje y el código de los puntajes
        cañaAmarilla = GameObject.Find("CañaAmarilla");
        objetoPuntaje= GameObject.Find("objetoPuntaje");
        puntajes= objetoPuntaje.GetComponent<almacenaPuntajesTRES>();
    }

    //Cuando la caña detecta una colisión
    void OnTriggerEnter(Collider other)
    {
        //Se muestra en consola que se atrapó un pez
        Debug.Log("Pez Atrapado" + "\n");

        //El GameObject con el que colisionó será el pez
        pez = other.gameObject;
        //Desactive este pez
        pez.SetActive(false);

        //Si el pez es del mismo color de la caña
        if (pez.tag == "Amarillo")
        {
            //Obtendrá dos puntos
            amarillos+=2;
            //Se va cambiando el texto
            textoMISMO.text = amarillos.ToString();
        }

        //Si no, significa que atrapó un pez que no debía
        else
        {
            //Obtendra 3 puntos en otros
            otros+=3;
            //Se va cambiando el texto
            textoOTRO.text = otros.ToString();
        }
    }

    void Update()
    {
        //Si el jugador ya atrapó todos los peces del mismo color de su caña
        if (amarillos == 14)
        {
            //Se calcula el puntaje final
            final = amarillos - otros;
            //Se cambia el texto
            textoPuntaje.text = final.ToString();
            //Se desactiva la caña
            cañaAmarilla.SetActive(false);

            //Si el jugador 1 no tiene puntaje, significa que es su turno
            if (puntajes.jugador1 == 0)
            {   
                //Se almacena su puntaje final
                puntajes.jugador1 = final;                
            }

            //Si el jugador 2 no tiene puntaje, significa que es su turno
            else if (puntajes.jugador2 == 0)
            {
                //Se almacena su puntaje final
                puntajes.jugador2 = final;
            }

            //Si no se cumplen las anteriores condiciones, significa que es sel turno del jugador 3
            else
            {
                //Se almacena su puntaje
                puntajes.jugador3 = final;
            }
        }
    }
}
