using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    public GameObject cañaDePescar;
    public b_SeleccionCaña codigoCaña;
    float velocidad = 2f;
    // Start is called before the first frame update
    void Start()
    {
        codigoCaña = GameObject.Find("botones").GetComponent<b_SeleccionCaña>();
    }

    // Update is called once per frame
    void Update()
    {
        if(codigoCaña.cañaSeleccionada=="Amarillo")
        {
            cañaDePescar= GameObject.Find("CañaAmarilla");
        }

        else if(codigoCaña.cañaSeleccionada == "Rojo")
        {
            cañaDePescar= GameObject.Find("CañaRoja");
        }

        else if(codigoCaña.cañaSeleccionada == "Verde")
        {
            cañaDePescar= GameObject.Find("CañaVerde");
        }
    }

      public void arriba()
    {
        cañaDePescar.transform.localPosition += new Vector3(0f, 5f, 0f) *Time.deltaTime;
    }

    public void abajo()
    {
        cañaDePescar.transform.localPosition += new Vector3(0f, -5f, 0f)*Time.deltaTime;
    }

    public void izq()
    {
        cañaDePescar.transform.position -= transform.right * velocidad * Time.deltaTime;
    }

    public void derecha()
    {        
        cañaDePescar.transform.position += transform.right * velocidad * Time.deltaTime;
    }  
 
       
}
