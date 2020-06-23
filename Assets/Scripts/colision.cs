using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    public int puntaje;
    void Start()
    {
        puntaje = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        //Output the Collider's GameObject's name
        Debug.Log("Se le pegó al topo");
        puntaje++;

    }
}
