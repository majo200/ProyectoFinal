using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colision : MonoBehaviour
{
    public int puntaje;
    public Text textoPuntaje;
    void Start()
    {
        puntaje = 0;
        
    }
    void OnTriggerEnter(Collider other)
    {
        //Output the Collider's GameObject's name
        Debug.Log("Se le pegó al topo");
        puntaje++;
        textoPuntaje.text = puntaje.ToString();

    }
}
