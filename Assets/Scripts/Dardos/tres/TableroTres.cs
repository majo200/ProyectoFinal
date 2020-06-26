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
    public GameObject tablero;
    //Variable para saber hacia qué lado va
    public string estado;
    //Variable que utilizaremos para la espera
    float secondsCounter;
    public GameObject b_x;
    public GameObject b_y;

    // Start is called before the first frame update
    void Start()
    {
        laser = GameObject.Find("Laser");
        dardo1 = GameObject.Find("DardoVerde");
        dardo2 = GameObject.Find("DardoNaranja");
        dardo3 = GameObject.Find("DardoAzul");
        dardo2.SetActive(false);
        dardo3.SetActive(false);
        estado = "derecha";
        secondsCounter = 0;
        tablero = GameObject.Find("tableroDardos");
        b_x = GameObject.Find("x");
        b_y = GameObject.Find("y");
        b_y.SetActive(false);
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
                b_x.SetActive(false);
                b_y.SetActive(true);
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
                b_x.SetActive(true);
                b_y.SetActive(false);
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

            if (seleccionadoX2== true && seleccionadoY2 == false)
            {
                Debug.Log("ENTRA");
                b_x.SetActive(false);
                b_y.SetActive(true);
                if (estado == "subiendo")
                {
                    metodoARRIBA();
                }
                else if (estado == "bajando")
                {
                    metodoABAJO();
                }
            }

            if (seleccionadoX2 == false)
            {
                Debug.Log("ENTRA2");
                b_x.SetActive(true);
                b_y.SetActive(false);
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


        if(seleccionadoY3 ==  true && seleccionadoX3 == true){
            lanzarDardo(dardo3);
        }

        if(turnoJugador3 == true){

            if (seleccionadoX3 == true && seleccionadoY3 == false)
            {
                b_x.SetActive(false);
                b_y.SetActive(true);
                if (estado == "subiendo")
                {
                    metodoARRIBA();
                }
                else if (estado == "bajando")
                {
                    metodoABAJO();
                }
            }

            if (seleccionadoX3 == false)
            {
                b_x.SetActive(true);
                b_y.SetActive(false);
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

        if (turnoJugador1 == true) {
            seleccionadoX1 = true;
         estado = "subiendo";
        }
        else if(turnoJugador2 == true){
                seleccionadoX2 = true;
            estado = "subiendo";
        }
        else if(turnoJugador3 == true){
                seleccionadoX3 = true;
            estado = "subiendo";
        }
        
    }
    public void seleccionarY(){
        
            if(turnoJugador1 == true){
                seleccionadoY1 = true;
            }else if(turnoJugador2 == true){
                seleccionadoY2 = true;
            }else if(turnoJugador3 == true){
                seleccionadoY3 = true;
            }
        
    }
    public void lanzarDardo(GameObject DardoColor){
        DardoColor.transform.Translate(0,0,-13f * Time.deltaTime);
        laser.SetActive(false);
        secondsCounter = 0;
    }
    void metodoDERECHA()
    {
        Debug.Log(secondsCounter);
        secondsCounter += Time.deltaTime;

        tablero.transform.position -= transform.right * 5f * (Time.deltaTime);

        if (secondsCounter > 5)
        {
            secondsCounter = 0;
            estado = "izquierda";
        }
    }

    void metodoIZQUIERDA()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position += transform.right * 5f * (Time.deltaTime);

        if (secondsCounter > 5)
        {
            secondsCounter = 0;
            estado = "derecha";
        }
    }

    void metodoARRIBA()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position -= transform.up * 5f * (Time.deltaTime);

        if (secondsCounter > 5)
        {
            secondsCounter = 0;
            estado = "bajando";
        }
    }

    void metodoABAJO()
    {
        secondsCounter += Time.deltaTime;

        tablero.transform.position += transform.up * 5f * (Time.deltaTime);

        if (secondsCounter > 5)
        {
            secondsCounter = 0;
            estado = "subiendo";
        }
    }

}
