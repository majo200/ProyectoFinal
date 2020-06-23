using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public beerPong scriptBeerPong;
    public Text txtTiempo;
    public Text puntajeJugador1;
    public Text puntajeJugador2;
    public Text txtGanador;
    public float tiempo = 60;
    public GameObject panelTurno2;
    public GameObject panelTurno1;
    public GameObject[] arrayVasos;
    public GameObject[] arrayVasos2;
    public float tiempoTranscurrido = 0;
    public GameObject panelGanador;

    void Start(){
        arrayVasos = GameObject.FindGameObjectsWithTag("pong");
        arrayVasos2 = GameObject.FindGameObjectsWithTag("pong2");
        for(int i = 0;i < arrayVasos2.Length;i++){
                arrayVasos2[i].SetActive(false);
            }
    }

    void Update(){
        tiempoTranscurrido += Time.deltaTime;
        tiempo -= Time.deltaTime;
        txtTiempo.text = ((int)tiempo).ToString() + " s";
        puntajeJugador1.text = (scriptBeerPong.Puntaje).ToString();
        puntajeJugador2.text = (scriptBeerPong.Puntaje2).ToString();
        if(tiempo < 0){
            panelTurno2.SetActive(true);
            for(int i = 0;i < arrayVasos.Length;i++){
                arrayVasos[i].SetActive(false);
            }
            for(int i = 0;i < arrayVasos2.Length;i++){
                arrayVasos2[i].SetActive(true);
            
            tiempo = 61f;
            }

        }

        if(tiempoTranscurrido > 121){
            if(scriptBeerPong.Puntaje > scriptBeerPong.Puntaje2){
                txtGanador.text = "JUGADOR 1";
            }else if(scriptBeerPong.Puntaje2 > scriptBeerPong.Puntaje){
                txtGanador.text = "JUGADOR 2";
            }else{
                txtGanador.text = "HAY UN EMPATE";
            }
            panelGanador.SetActive(true);
        }

    }
}
