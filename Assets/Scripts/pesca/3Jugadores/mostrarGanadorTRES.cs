using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mostrarGanadorTRES : MonoBehaviour
{
    //MÉTODO PARA MOSTRAR EL GANADOR CUANDO SON 3 JUGADORES
    
    //Variables que almacenarán el código de puntajes
    public almacenaPuntajesTRES puntaje;

    //Panel en donde se mostrará el ganador, con su respectivo texto
    public GameObject panelGanador;
    public Text texto;
    public GameObject objetoTexto;

    //Variable que se utilizará para la espera
    float secondsCounter;

    //Panel donde se encuentra el control
    public GameObject panelControl;

    //Panel donde se encuentra el mensaje de calculando
    public GameObject calculando;

    void Start()
    {    
        //Encontramos los objetos y componentes
        objetoTexto = GameObject.Find("objetoTexto");
        texto = objetoTexto.GetComponent<Text>();
        puntaje = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajesTRES>();
        //Inicia en cero
        secondsCounter = 0; 
        panelControl= GameObject.Find("panel_Teclado");
        calculando = GameObject.FindWithTag("CALCULANDO");
        //Desactivamos tanto el panel de calculando y el panel del ganador 
        calculando.SetActive(false); 
         panelGanador = GameObject.Find("panelGanador");
        panelGanador.SetActive(false);
    }

    void Update()
    {
        //Todos estos if es porque en algunos casos marca error al recargarse la escena 
        //por lo que se debe comprobar que si los haya encontrado bien
        if(calculando==null)
         {
            calculando = GameObject.FindWithTag("CALCULANDO");    
         }

        if(panelControl==null)
        {
            panelControl= GameObject.Find("panel_Teclado");
        }
        if(objetoTexto==null)
        {
            objetoTexto = GameObject.Find("objetoTexto");
            texto = objetoTexto.GetComponent<Text>();
        }
        if(panelGanador==null)
        {
            panelGanador = GameObject.Find("panelGanador");
        }

        //Si el jugador 3 ya tiene un puntaje, es decir, que ya jugaron todas las personas
        if (puntaje.jugador3 != 0)
        {       
                //Active el mensaje de calculando y desactive los controles
                calculando.SetActive(true); 
                panelControl.SetActive(false);

                //Muestra en consola la cuenta regresiva
                Debug.Log("sec" + secondsCounter);      
            
                //este método es para que espere alrededor de 7 segundos
                secondsCounter += Time.deltaTime;
                //Si ya pasó este tiempo
                if (secondsCounter>7 )
                {
                    //Active el panel del ganador
                    panelGanador.SetActive(true);

                    //Si el jugador 1 obtuvo el mayor puntaje, gana el jugador 1
                    if (puntaje.jugador1 > puntaje.jugador2 && puntaje.jugador1>puntaje.jugador3)
                    {
                      texto.text = "El Jugador #1 con" + puntaje.jugador1.ToString() + " puntos";
                    }

                    //Si el jugador 2 obtuvo el mayor puntaje, gana el jugador 2
                    else if(puntaje.jugador2>puntaje.jugador1 && puntaje.jugador2>puntaje.jugador3)                    
                    {
                      texto.text = "El Jugador #2 con " + puntaje.jugador2.ToString() + " puntos";
                    }

                    //Si el jugador 3 obtuvo el mayor puntaje, gana el jugador 3
                    else if(puntaje.jugador3>puntaje.jugador1 && puntaje.jugador3>puntaje.jugador1)
                    {
                       texto.text = "El Jugador #3 con " + puntaje.jugador3.ToString() + " puntos";
                    }

                    //Si todos los jugadores obtuvieron el mismo puntaje, empate entre los 3 jugadores
                    else if(puntaje.jugador1 == puntaje.jugador2 && puntaje.jugador1 == puntaje.jugador3)
                    {
                      texto.text = "Ha ocurrido un empate entre los 3 jugadores, todos obtuvieron " + puntaje.jugador3.ToString() + " puntos";
                    }

                    //Empate jugador 2 y 1
                    else if (puntaje.jugador1 == puntaje.jugador2)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #1 y el jugador #2, ambos obtuvieron " + puntaje.jugador2.ToString() + " puntos";
                    }

                    //Empate jugador 1 y 3
                    else if (puntaje.jugador1 == puntaje.jugador3)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #1 y el jugador #3, ambos obtuvieron " + puntaje.jugador1.ToString() + " puntos";
                    }

                    //Empate jugador 3 y 2
                    else if (puntaje.jugador3 == puntaje.jugador2)
                    {
                      texto.text = "Ha ocurrido un empate entre el jugador #2 y el jugador #3, ambos obtuvieron " + puntaje.jugador2.ToString() + " puntos";
                    }
                    
                } 
        }
    }
}
