using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesSeleccion : MonoBehaviour
{
    public Tablero  scripTablero;
    
    public void btnSeleccionX(){
        scripTablero.seleccionarX();
        Debug.Log("SeleccionandoX");
    }
    public void btnSeleccionY(){
        scripTablero.seleccionarY();
        Debug.Log("SeleccionandoY");
    }
}
