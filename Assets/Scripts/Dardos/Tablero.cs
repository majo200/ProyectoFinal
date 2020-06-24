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
    public GameObject tablero;
    //Variable para saber hacia qué lado va
    public string estado;
    //Variable que utilizaremos para la espera
    float secondsCounter;

    // Start is called before the first frame update
    void Start()
    {
        laser = GameObject.Find("Laser");
        dardo1 = GameObject.Find("DardoVerde");
        dardo2 = GameObject.Find("DardoNaranja");
        dardo2.SetActive(false);
        estado = "derecha";
        secondsCounter = 0;
        tablero = GameObject.Find("tableroDardos");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(estado);
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
                if (estado == "subiendo")
                {
                    metodoARRIBA();
                }
                else if (estado == "bajando")
                {
                    metodoABAJO();
                }            
                
            }

            if(seleccionadoX1 == false){
                if (estado == "derecha")
                {
                    metodoDERECHA();
                }
                else if (estado == "izquierda")
                {
                    metodoIZQUIERDA();
                }
                
            }
        }


        if(seleccionadoY2 ==  true && seleccionadoX2 == true){
            lanzarDardo(dardo2);
        }

        if(turnoJugador2 == true){

            if(seleccionadoX2 == true && seleccionadoY2 == false){
                if (estado == "subiendo")
                {
                    metodoARRIBA();
                }
                else if (estado == "bajando")
                {
                    metodoABAJO();
                }

            }

            if(seleccionadoX2 == false){
                if (estado == "derecha")
                {
                    metodoDERECHA();
                }
                else if (estado == "izquierda")
                {
                    metodoIZQUIERDA();
                }

            }
        }
        
    }

    public void seleccionarX(){
        
            if(turnoJugador1 == true){
                seleccionadoX1 = true;
                estado = "subiendo";
                contadorSelección1 = 1;
            }else if(turnoJugador2 == true){
                seleccionadoX2 = true;
                estado = "subiendo";
            }
        
    }
    public void seleccionarY(){
        
            if(turnoJugador1 == true){
                seleccionadoY1 = true;
                contadorSelección1 = 0;
            }else if(turnoJugador2 == true){
                seleccionadoY2 = true;
            }
        
    }
    public void lanzarDardo(GameObject DardoColor){
        DardoColor.transform.Translate(0,0,-13f * Time.deltaTime);
        laser.SetActive(false);
    }

    void metodoDERECHA()
    {
        Debug.Log(secondsCounter);
        secondsCounter += Time.deltaTime;

        tablero.transform.position += transform.right *5f* (Time.deltaTime);

        if (secondsCounter > 4)
        {
            secondsCounter = 0;
            estado = "izquierda";
        }
    }

    void metodoIZQUIERDA()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position -= transform.right *5f* (Time.deltaTime);

        if (secondsCounter > 4)
        {
            secondsCounter = 0;
            estado = "derecha";            
        }
    }

    void metodoARRIBA()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position += transform.up * 5f * (Time.deltaTime);

        if (secondsCounter > 4)
        {
            secondsCounter = 0;
            estado = "bajando";
        }
    }

    void metodoABAJO()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position -= transform.up * 5f * (Time.deltaTime);

        if (secondsCounter > 4)
        {
            secondsCounter = 0;
            estado = "subiendo";
        }
    }
}
