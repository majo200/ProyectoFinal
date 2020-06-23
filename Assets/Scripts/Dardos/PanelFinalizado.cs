using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFinalizado : MonoBehaviour
{

    public Tablero scriptTablero;
    public Text txtGanador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void elegirGanador(){
        if(scriptTablero.puntajeJugador1 > scriptTablero.puntajeJugador2){
            txtGanador.text = "JUGADOR 1";
        }else if(scriptTablero.puntajeJugador2 > scriptTablero.puntajeJugador1){
            txtGanador.text = "JUGADOR 2";
        }else if(scriptTablero.puntajeJugador1 == scriptTablero.puntajeJugador2){
            txtGanador.text = "EMPATE";
        }
    }
}
