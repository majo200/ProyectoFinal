using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoVerdeTres : MonoBehaviour
{
    
    public TableroTres scriptTablero;
    public GameObject tablero;

    void Start()
    {
        tablero = GameObject.Find("tableroDardos");
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Diez"){
            Debug.Log("Toco el Diez");
            scriptTablero.puntajeJugador1 += 10;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Nueve"){
            Debug.Log("Toco el Nueve");
            scriptTablero.puntajeJugador1 += 9;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Ocho"){
            Debug.Log("Toco el Ocho");
            scriptTablero.puntajeJugador1 += 8;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Siete"){
            Debug.Log("Toco el Siete");
            scriptTablero.puntajeJugador1 += 7;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Seis"){
            Debug.Log("Toco el Seis");
            scriptTablero.puntajeJugador1 += 6;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cinco"){
            Debug.Log("Toco el Cinco");
            scriptTablero.puntajeJugador1 += 5;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cuatro"){
            Debug.Log("Toco el Cuatro");
            scriptTablero.puntajeJugador1 += 4;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Tres"){
            Debug.Log("Toco el Tres");
            scriptTablero.puntajeJugador1 += 3;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Dos"){
            Debug.Log("Toco el Dos");
            scriptTablero.puntajeJugador1 += 2;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Uno"){
            Debug.Log("Toco el Uno");
            scriptTablero.puntajeJugador1++;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Pared"){
            Debug.Log("Toco la pared");
            restablecerPosicion();
        }
    }

    public void restablecerPosicion(){
        tablero.transform.localPosition = new Vector3(-16.0201f, 0.16f, 6.63f);
        scriptTablero.estado = "derecha";
        transform.localPosition = new Vector3(0f,0f,0f);
        scriptTablero.seleccionadoX1 = false;
        scriptTablero.seleccionadoY1 = false;
        scriptTablero.laser.SetActive(true);
        scriptTablero.tirosJugador1++;
        if(scriptTablero.tirosJugador1 == 3)
        {
            scriptTablero.tirosJugador1 = 0;
            scriptTablero.turnoJugador1 = false;
            scriptTablero.turnoJugador2 = true;
            scriptTablero.dardo1.SetActive(false);
            scriptTablero.dardo2.SetActive(true);
            Debug.Log("Cambio de jugador");
           
        }
    }
}
