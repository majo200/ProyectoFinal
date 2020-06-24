using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesSeleccionBeer : MonoBehaviour
{
    public beerPong scriptBeer;

    public void seleccionarX(){
        scriptBeer.direccionEjeX();
    }

    public void seleccionarY(){
        scriptBeer.direccionEjeY();
    }
}
