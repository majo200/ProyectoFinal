using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionPescaTRES : MonoBehaviour
{   
    //MÉTODO PARA LA CAÑA ROJA, ES IGUAL AL DE LA CAÑA AMARILLA, PARA LOS COMENTARIOS DE LA EXPLICACIÓN 
    //VER EL SCRIPT: colisionAmarilloTRES

    public almacenaPuntajesTRES puntajes;
    public GameObject objetoPuntaje;
    public int rojos;
    public int otros;
    public int final;
    public GameObject pez;
    public GameObject cañaRoja;
    public Text textoPuntaje;
    public Text textoMISMO;
    public Text textoOTRO;
   
    void Start()
    {
        rojos = 0;
        otros = 0;
        final = 0;
        cañaRoja = GameObject.Find("CañaRoja");
        objetoPuntaje= GameObject.Find("objetoPuntaje");
        puntajes= objetoPuntaje.GetComponent<almacenaPuntajesTRES>();       
    }

    void OnTriggerEnter(Collider other)
    {        
        Debug.Log("Pez Atrapado" + "\n");
        pez = other.gameObject;
        pez.SetActive(false);

        if (pez.tag=="Rojo")
        {
            rojos+=2;
            textoMISMO.text = rojos.ToString();
        }           

        else
        {
            otros+=3;
             textoOTRO.text = otros.ToString();
        }
        
    }

    void Update()
    {
        if (rojos == 14)
        {
            final = rojos - otros;
            cañaRoja.SetActive(false);
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
