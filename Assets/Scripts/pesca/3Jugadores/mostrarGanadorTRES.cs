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
    public GameObject calculando;
    void Start()
    {       
        objetoTexto = GameObject.Find("objetoTexto");
        texto = objetoTexto.GetComponent<Text>();
        puntaje = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajesTRES>();
        secondsCounter = 0; 
        panelControl= GameObject.Find("panel_Teclado");
        calculando = GameObject.FindWithTag("CALCULANDO"); 
        calculando.SetActive(false); 
         panelGanador = GameObject.Find("panelGanador");
        panelGanador.SetActive(false);
    }

    void Update()
    {
        if(calculando==null)
         {
            calculando = GameObject.FindWithTag("CALCULANDO");    
         }

        if(panelControl==null)
        {
            panelControl= GameObject.Find("panel_Teclado");
        }

        if (puntaje.jugador3 != 0)
        {       
                calculando.SetActive(true); 
                panelControl.SetActive(false);
                Debug.Log("sec" + secondsCounter);          
                secondsCounter += Time.deltaTime;
                if (secondsCounter>7 && secondsCounter < 7.1)
                {
                    panelGanador.SetActive(true);
                    if (puntaje.jugador1 > puntaje.jugador2 && puntaje.jugador1>puntaje.jugador3)
                    {
                      texto.text = "El Jugador #1 con" + puntaje.jugador1.ToString() + " puntos";
                    }

                    else if(puntaje.jugador2>puntaje.jugador1 && puntaje.jugador2>puntaje.jugador3)                    
                    {
                      texto.text = "El Jugador #2 con " + puntaje.jugador2.ToString() + " puntos";
                    }

                    else if(puntaje.jugador3>puntaje.jugador1 && puntaje.jugador3>puntaje.jugador1)
                    {
                       texto.text = "El Jugador #3 con " + puntaje.jugador3.ToString() + " puntos";
                    }

                    else if(puntaje.jugador1 == puntaje.jugador2 && puntaje.jugador1 == puntaje.jugador3)
                    {
                      texto.text = "Ha ocurrido un empate entre los 3 jugadores, todos obtuvieron " + puntaje.jugador3.ToString() + " puntos";
                    }

                    else if (puntaje.jugador1 == puntaje.jugador2)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #1 y el jugador #2, ambos obtuvieron " + puntaje.jugador2.ToString() + " puntos";
                    }

                    else if (puntaje.jugador1 == puntaje.jugador3)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #1 y el jugador #3, ambos obtuvieron " + puntaje.jugador1.ToString() + " puntos";
                    }

                    else if (puntaje.jugador3 == puntaje.jugador2)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #2 y el jugador #3, ambos obtuvieron " + puntaje.jugador2.ToString() + " puntos";
                    }
                    
                } 
        }
    }
}
