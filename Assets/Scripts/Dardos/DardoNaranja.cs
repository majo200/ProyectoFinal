using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoNaranja : MonoBehaviour
{
    public Tablero scriptTablero;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Diez"){
            Debug.Log("Toco el Diez");
            scriptTablero.puntajeJugador2 += 10;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Nueve"){
            Debug.Log("Toco el Nueve");
            scriptTablero.puntajeJugador2 += 9;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Ocho"){
            Debug.Log("Toco el Ocho");
            scriptTablero.puntajeJugador2 += 8;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Siete"){
            Debug.Log("Toco el Siete");
            scriptTablero.puntajeJugador2 += 7;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Seis"){
            Debug.Log("Toco el Seis");
            scriptTablero.puntajeJugador2 += 6;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cinco"){
            Debug.Log("Toco el Cinco");
            scriptTablero.puntajeJugador2 += 5;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cuatro"){
            Debug.Log("Toco el Cuatro");
            scriptTablero.puntajeJugador2 += 4;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Tres"){
            Debug.Log("Toco el Tres");
            scriptTablero.puntajeJugador2 += 3;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Dos"){
            Debug.Log("Toco el Dos");
            scriptTablero.puntajeJugador2 += 2;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Uno"){
            Debug.Log("Toco el Uno");
            scriptTablero.puntajeJugador2++;
            restablecerPosicion();
        }else{
            Debug.Log("Toco el Tablero");
            restablecerPosicion();
        }
    }

    public void restablecerPosicion(){
        transform.position = new Vector3(13.123f,6.06f,-3.03f);
        scriptTablero.seleccionadoX2 = false;
        scriptTablero.seleccionadoY2 = false;
        scriptTablero.laser.SetActive(true);
        scriptTablero.tirosJugador2++;
        if(scriptTablero.tirosJugador2 >= 3){
            scriptTablero.turnoJugador2 = false;
            scriptTablero.turnoJugador1 = true;
            scriptTablero.dardo2.SetActive(false);
            scriptTablero.dardo1.SetActive(true);
            Debug.Log("Cambio de jugador");
            scriptTablero.ronda++;
            scriptTablero.tirosJugador2 = 0;
        }
    }
}
