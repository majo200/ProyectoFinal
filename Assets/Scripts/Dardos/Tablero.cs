using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tablero : MonoBehaviour
{

    //UI
    public Text txtTurnoActivo;
    public Text txtPuntaje1;
    public Text txtPuntaje2;
    public GameObject PanelFinalizado;

    public float velocidad = 7f;
    public bool turnoJugador1 = true;
    public bool turnoJugador2 = false;
    public bool seleccionadoX1 = false;
    public bool seleccionadoY1 = false;
    public bool seleccionadoX2 = false;
    public bool seleccionadoY2 = false;
    public GameObject laser;
    public GameObject dardo1;
    public GameObject dardo2;
    public int puntajeJugador1 = 0;
    public int puntajeJugador2 = 0;
    public int ronda = 1;
    public int tirosJugador1 = 0;
    public int tirosJugador2 = 0;
    public int contadorSelección1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        laser = GameObject.Find("Laser");
        dardo1 = GameObject.Find("DardoVerde");
        dardo2 = GameObject.Find("DardoNaranja");
        dardo2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ronda > 7){
            PanelFinalizado.SetActive(true);
        }

        txtPuntaje1.text = puntajeJugador1.ToString();
        txtPuntaje2.text = puntajeJugador2.ToString();

        if(turnoJugador1 == true){
            txtTurnoActivo.text = "Turno Jugador 1";
        }else if(turnoJugador2 == true){
            txtTurnoActivo.text = "Turno Jugador 2";
        }
    
        if(seleccionadoY1 ==  true && seleccionadoX1 == true){
            lanzarDardo(dardo1);
        }

        if(turnoJugador1 == true){

            if(seleccionadoX1 == true && seleccionadoY1 == false && contadorSelección1 == 1){
                if(transform.position.y > 12f){
                velocidad *= -1f;
                }else if(transform.position.y < -1f){
                velocidad *= -1f;
                }
                transform.Translate(0,velocidad * Time.deltaTime,0);
                seleccionarY();
            }

            if(seleccionadoX1 == false){
                if(transform.position.z > 5.22f){
                velocidad *= -1f;
                }else if(transform.position.z < -7f){
                velocidad *= -1f;
                }
                transform.Translate(velocidad * Time.deltaTime,0,0);
                seleccionarX();
            }
        }


        if(seleccionadoY2 ==  true && seleccionadoX2 == true){
            lanzarDardo(dardo2);
        }

        if(turnoJugador2 == true){

            if(seleccionadoX2 == true && seleccionadoY2 == false){
                if(transform.position.y > 12f){
                velocidad *= -1f;
                }else if(transform.position.y < -1f){
                velocidad *= -1f;
                }
                transform.Translate(0,velocidad * Time.deltaTime,0);
                seleccionarY();
            }

            if(seleccionadoX2 == false){
                if(transform.position.z > 5.22f){
                velocidad *= -1f;
                }else if(transform.position.z < -7f){
                velocidad *= -1f;
                }
                transform.Translate(velocidad * Time.deltaTime,0,0);
                seleccionarX();
            }
        }
        
    }

    public void seleccionarX(){
        if(Input.touchCount != 0)
        {
            if(turnoJugador1 == true){
                seleccionadoX1 = true;
                contadorSelección1 = 1;
            }else if(turnoJugador2 == true){
                seleccionadoX2 = true;
            }
        }
    }
    public void seleccionarY(){
        if(Input.touchCount != 0)
        {
            if(turnoJugador1 == true){
                seleccionadoY1 = true;
                contadorSelección1 = 0;
            }else if(turnoJugador2 == true){
                seleccionadoY2 = true;
            }
        }
    }
    public void lanzarDardo(GameObject DardoColor){
        DardoColor.transform.Translate(0,0,-13f * Time.deltaTime);
        laser.SetActive(false);
    }
}
