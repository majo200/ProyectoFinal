using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionVerdeTRES : MonoBehaviour
{
    //MÉTODO PARA LA CAÑA VERDE, ES IGUAL AL DE LA CAÑA AMARILLA, PARA LOS COMENTARIOS DE LA EXPLICACIÓN 
    //VER EL SCRIPT: colisionAmarilloTRES

    public almacenaPuntajesTRES puntajes;
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
        puntajes= objetoPuntaje.GetComponent<almacenaPuntajesTRES>();        
    }

    void OnTriggerEnter(Collider other)
    {        
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
            cañaVerde.SetActive(false);
            textoPuntaje.text = final.ToString();
            if (puntajes.jugador1 == 0)
            {
               puntajes.jugador1 = final;
            }
            else if (puntajes.jugador2 == 0)
            {
                puntajes.jugador2 = final;
            }
            else
            {
                puntajes.jugador3 = final;
            }
        }
    }
}
