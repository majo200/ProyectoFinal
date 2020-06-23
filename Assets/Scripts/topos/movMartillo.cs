using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMartillo : MonoBehaviour
{
    
    public GameObject martillo;    
    float velocidad = 3.5f;    
    public bool bajando;
    float secondsCounter;
 
    void Start()
    {
        martillo = GameObject.Find("martillo"); 
        bajando=true;
        secondsCounter = 0;            
    }

    public void derecha()
    {
        martillo.transform.localPosition += new Vector3(0f, 0f, 6f) * Time.deltaTime;
    }

    public void izquierda()
    {
        martillo.transform.localPosition -= new Vector3(0f, 0f, 6f)*   Time.deltaTime;
    }

    public void arriba()
    {
        martillo.transform.position -= transform.right * velocidad * Time.deltaTime;
    }

    public void abajo()
    {        
        martillo.transform.position += transform.right * velocidad * Time.deltaTime;
    }  

    public void golpear()
    {           
        Debug.Log("CLICK");
        if(bajando==true)
        {
            martillo.transform.position -= transform.up *2;            
        }
        else
        {
            martillo.transform.position += transform.up *  2;
        }
        bajando=!bajando;
    }

  
}
