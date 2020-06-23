using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class almacenaPuntajesTRES : MonoBehaviour
{
    //CÓDIGO QUE ALMACENA PUNTAJES PARA 3 JUGADORES
    //Variables que almacenarán el puntaje
    public int jugador1;
    public int jugador2;
    public int jugador3;
    //Variable de turno
    public int turno;
    //Objeto que almacena los puntajes
    public GameObject codigoPuntajes;

    //Para que no se borre la información cuando se recargue la escena
    void Awake()
    {
        codigoPuntajes = GameObject.Find("objetoPuntaje");
        DontDestroyOnLoad(codigoPuntajes);

        //Método para que no se duplique el objeto
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Al iniciar los puntajes son ceros y el turno es 2(por los valores del otro código)
        jugador1 = 0;
        jugador2 = 0;
        jugador3 = 0;
        turno = 2;
    }

}
