using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mostrarGanadorTRES : MonoBehaviour
{
    public almacenaPuntajesTRES puntaje;
    public GameObject panelGanador;
    public Text texto;
    public GameObject objetoTexto;
    float secondsCounter;
    public GameObject panelControl;
    void Start()
    {
        panelGanador = GameObject.Find("panelGanador");
        objetoTexto = GameObject.Find("objetoTexto");
        texto = objetoTexto.GetComponent<Text>();
        puntaje = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajesTRES>();
        secondsCounter = 0; 
        panelControl= GameObject.Find("panel_Teclado");
    }

    void Update()
    {
        if (puntaje.jugador3 != 0)
        {            
                panelControl.SetActive(false);
                Debug.Log("sec" + secondsCounter);          
                secondsCounter += Time.deltaTime;
                if (secondsCounter>7 && secondsCounter < 7.1)
                {
                    panelGanador.SetActive(true);
                    if (puntaje.jugador1 > puntaje.jugador2 && puntaje.jugador1>puntaje.jugador3)
                    {
                      texto.text = "El ganador es el Jugador #1 con" + puntaje.jugador1.ToString() + " puntos";
                    }

                    else if(puntaje.jugador2>puntaje.jugador1 && puntaje.jugador2>puntaje.jugador3)                    
                    {
                      texto.text = "El ganador es el Jugador #2 con " + puntaje.jugador2.ToString() + " puntos";
                    }

                    else
                    {
                       texto.text = "El ganador es el Jugador #3 con " + puntaje.jugador3.ToString() + " puntos";
                    }
                    
                } 
        }
    }
}
