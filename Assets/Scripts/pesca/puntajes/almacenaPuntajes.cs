using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class almacenaPuntajes : MonoBehaviour
{
    public int jugador1;
    public int jugador2;
    public GameObject codigoPuntajes;
    public int turno;
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
        turno = 2;
    }

    void Update()
    {
      
    }
}
