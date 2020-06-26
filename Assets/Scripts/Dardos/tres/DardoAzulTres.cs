using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DardoAzulTres : MonoBehaviour
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
            scriptTablero.puntajeJugador3 += 10;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Nueve"){
            Debug.Log("Toco el Nueve");
            scriptTablero.puntajeJugador3 += 9;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Ocho"){
            Debug.Log("Toco el Ocho");
            scriptTablero.puntajeJugador3 += 8;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Siete"){
            Debug.Log("Toco el Siete");
            scriptTablero.puntajeJugador3 += 7;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Seis"){
            Debug.Log("Toco el Seis");
            scriptTablero.puntajeJugador3 += 6;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cinco"){
            Debug.Log("Toco el Cinco");
            scriptTablero.puntajeJugador3 += 5;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Cuatro"){
            Debug.Log("Toco el Cuatro");
            scriptTablero.puntajeJugador3 += 4;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Tres"){
            Debug.Log("Toco el Tres");
            scriptTablero.puntajeJugador3 += 3;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Dos"){
            Debug.Log("Toco el Dos");
            scriptTablero.puntajeJugador3 += 2;
            restablecerPosicion();
        }else if(collision.gameObject.tag == "Uno"){
            Debug.Log("Toco el Uno");
            scriptTablero.puntajeJugador3++;
            restablecerPosicion();
        }else{
            Debug.Log("Toco el Tablero");
            restablecerPosicion();
        }
    }

    public void restablecerPosicion(){
        tablero.transform.localPosition = new Vector3(-16.0201f, 0.16f, 6.63f);
        scriptTablero.estado = "derecha";
        transform.localPosition = new Vector3(-25.1480f, 5.680f, -3.570f);
        scriptTablero.seleccionadoX3 = false;
        scriptTablero.seleccionadoY3 = false;
        scriptTablero.laser.SetActive(true);
        scriptTablero.tirosJugador3++;
        if(scriptTablero.tirosJugador3 ==3)
        {
            scriptTablero.tirosJugador3 = 0;
            scriptTablero.turnoJugador3 = false;
            scriptTablero.turnoJugador1 = true;
            scriptTablero.dardo3.SetActive(false);
            scriptTablero.dardo1.SetActive(true);
            Debug.Log("Cambio de jugador");
            scriptTablero.ronda++;            
        }
    }
}
