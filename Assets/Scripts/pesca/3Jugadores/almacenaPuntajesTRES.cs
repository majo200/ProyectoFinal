using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class almacenaPuntajesTRES : MonoBehaviour
{
    public int jugador1;
    public int jugador2;
    public int jugador3;
    public int turno;
    public GameObject codigoPuntajes;
    void Awake()
    {
        codigoPuntajes = GameObject.Find("objetoPuntaje");
        

        DontDestroyOnLoad(codigoPuntajes);
     
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        jugador1 = 0;
        jugador2 = 0;
        jugador3 = 0;
        turno = 2;
    }

    void Update()
    {
      
    }
}
