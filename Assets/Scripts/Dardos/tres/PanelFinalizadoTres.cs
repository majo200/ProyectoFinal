using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFinalizadoTres : MonoBehaviour
{
    public TableroTres scriptTablero;
    public Text txtGanador;

    void Start(){
        elegirGanador();
    }

    public void elegirGanador(){
        if(scriptTablero.puntajeJugador1 > scriptTablero.puntajeJugador2 && scriptTablero.puntajeJugador1 > scriptTablero.puntajeJugador3){
            txtGanador.text  = "Jugador 1";
        }else if(scriptTablero.puntajeJugador2 > scriptTablero.puntajeJugador1 && scriptTablero.puntajeJugador2 > scriptTablero.puntajeJugador3){
            txtGanador.text = "Jugador 2";
        }else if(scriptTablero.puntajeJugador3 > scriptTablero.puntajeJugador1 && scriptTablero.puntajeJugador3 > scriptTablero.puntajeJugador2){
            txtGanador.text = "Jugador 3";
        }else{
            txtGanador.text = "Hay un empate";
        }
    }
}
