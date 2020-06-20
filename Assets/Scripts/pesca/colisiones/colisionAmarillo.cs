using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionAmarillo : MonoBehaviour
{
    public almacenaPuntajes puntajes;
    public GameObject objetoPuntaje;
    public int amarillos;
    public int otros;
    public int final;
    public GameObject pez;
    public GameObject cañaAmarilla;
    public Text textoPuntaje;
    public Text textoMISMO;
    public Text textoOTRO;

    void Start()
    {
        amarillos = 0;
        otros = 0;
        final = 0;
        cañaAmarilla = GameObject.Find("CañaAmarilla");
        objetoPuntaje= GameObject.Find("objetoPuntaje");
        puntajes= objetoPuntaje.GetComponent<almacenaPuntajes>();
    }
    void OnTriggerEnter(Collider other)
    {
        //Output the Collider's GameObject's name
        Debug.Log("Pez Atrapado" + "\n");
        pez = other.gameObject;
        pez.SetActive(false);

        if (pez.tag == "Amarillo")
        {
            amarillos+=2;
            textoMISMO.text = amarillos.ToString();

        }


        else
        {
            otros+=3;
             textoOTRO.text = otros.ToString();
        }


    }
    void Update()
    {
        if (amarillos == 14)
        {
            final = amarillos - otros;
            textoPuntaje.text = final.ToString();
            cañaAmarilla.SetActive(false);
            
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
