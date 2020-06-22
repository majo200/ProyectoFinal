using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarGanador : MonoBehaviour
{
    public almacenaPuntajes puntaje;
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
        puntaje = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajes>();
        secondsCounter = 0; 
        panelControl= GameObject.Find("panel_Teclado");
        panelGanador = GameObject.Find("panelGanador");
        calculando = GameObject.FindWithTag("CALCULANDO"); 
        calculando.SetActive(false); 
        panelGanador.SetActive(false);
    }

    void Update()
    {
         if(calculando==null)
         {
            calculando = GameObject.FindWithTag("CALCULANDO");    
         }
         
        if (puntaje.jugador2 != 0)
        {       
                calculando.SetActive(true); 
                panelControl.SetActive(false);              
                Debug.Log("sec" + secondsCounter);          
                secondsCounter += Time.deltaTime;
                if (secondsCounter>7 && secondsCounter < 7.1)
                {
                    panelGanador.SetActive(true);                    
                    if (puntaje.jugador1 > puntaje.jugador2)
                    {
                      texto.text = "Jugador #1 con " + puntaje.jugador1.ToString() + " puntos";
                    }

                    else if (puntaje.jugador1 < puntaje.jugador2)
                    {
                      texto.text = "Jugador #2 con " + puntaje.jugador2.ToString() + " puntos";
                    }

                    else
                    {
                      texto.text = "Ha ocurrido un empate entre los jugadores, ambos obtuvieron " + puntaje.jugador2.ToString() + " puntos";
                    }
                    
                } 
        }
    }
}
