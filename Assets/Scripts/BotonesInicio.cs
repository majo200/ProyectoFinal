using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInicio : MonoBehaviour
{
    
    public void juagoSeleccionado(string escena){
        SceneManager.LoadScene(escena);
    }

}
