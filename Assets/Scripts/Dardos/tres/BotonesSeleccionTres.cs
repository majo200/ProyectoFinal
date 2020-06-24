using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesSeleccionTres : MonoBehaviour
{
    public TableroTres  scripTablero;
    
    public void btnSeleccionX(){
        scripTablero.seleccionarX();
        Debug.Log("SeleccionandoX");
    }
    public void btnSeleccionY(){
        scripTablero.seleccionarY();
        Debug.Log("SeleccionandoY");
    }
}
