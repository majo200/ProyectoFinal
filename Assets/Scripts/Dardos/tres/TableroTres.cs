using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableroTres : MonoBehaviour
{
    //UI
    public Text txtTurnoActivo;
    public Text txtPuntaje1;
    public Text txtPuntaje2;
    public Text txtPuntaje3;
    public GameObject PanelFinalizado;

    public float velocidad = 7f;
    public bool turnoJugador1 = true;
    public bool turnoJugador2 = false;
    public bool turnoJugador3 = false;
    public bool seleccionadoX1 = false;
    public bool seleccionadoY1 = false;
    public bool seleccionadoX2 = false;
    public bool seleccionadoY2 = false;
    public bool seleccionadoX3 = false;
    public bool seleccionadoY3 = false;
    public GameObject laser;
    public GameObject dardo1;
    public GameObject dardo2;
    public GameObject dardo3;
    public int puntajeJugador1 = 0;
    public int puntajeJugador2 = 0;
    public int puntajeJugador3 = 0;
    public int ronda = 1;
    public int tirosJugador1 = 0;
    public int tirosJugador2 = 0;
    public int tirosJugador3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        laser = GameObject.Find("Laser");
        dardo1 = GameObject.Find("DardoVerde");
        dardo2 = GameObject.Find("DardoNaranja");
        dardo3 = GameObject.Find("DardoAzul");
        dardo2.SetActive(false);
        dardo3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ronda > 7){
            PanelFinalizado.SetActive(true);
        }

        txtPuntaje1.text = puntajeJugador1.ToString();
        txtPuntaje2.text = puntajeJugador2.ToString();
        txtPuntaje3.text = puntajeJugador3.ToString();

        if(turnoJugador1 == true){
            txtTurnoActivo.text = "Turno Jugador 1";
        }else if(turnoJugador2 == true){
            txtTurnoActivo.text = "Turno Jugador 2";
        }else if(turnoJugador3 == true){
            txtTurnoActivo.text = "Turno Jugador 3";
        }
    
        if(seleccionadoY1 ==  true && seleccionadoX1 == true){
            lanzarDardo(dardo1);
        }

        if(turnoJugador1 == true){

            if(seleccionadoX1 == true && seleccionadoY1 == false){
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


        if(seleccionadoY3 ==  true && seleccionadoX3 == true){
            lanzarDardo(dardo3);
        }

        if(turnoJugador3 == true){

            if(seleccionadoX3 == true && seleccionadoY3 == false){
                if(transform.position.y > 12f){
                velocidad *= -1f;
                }else if(transform.position.y < -1f){
                velocidad *= -1f;
                }
                transform.Translate(0,velocidad * Time.deltaTime,0);
                seleccionarY();
            }

            if(seleccionadoX3 == false){
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
        if(Input.GetKey(KeyCode.X)){
            if(turnoJugador1 == true){
                seleccionadoX1 = true;
            }else if(turnoJugador2 == true){
                seleccionadoX2 = true;
            }else if(turnoJugador3 == true){
                seleccionadoX3 = true;
            }
        }
    }
    public void seleccionarY(){
        if(Input.GetKey(KeyCode.Y)){
            if(turnoJugador1 == true){
                seleccionadoY1 = true;
            }else if(turnoJugador2 == true){
                seleccionadoY2 = true;
            }else if(turnoJugador3 == true){
                seleccionadoY3 = true;
            }
        }
    }
    public void lanzarDardo(GameObject DardoColor){
        DardoColor.transform.Translate(0,0,-13f * Time.deltaTime);
        laser.SetActive(false);
    }
}
