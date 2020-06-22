using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasarEscena : MonoBehaviour
{    
    float secondsCounter;    
    public tiempo codigoTiempo;
    public almacenaPuntajes puntajes;    
    
    // Start is called before the first frame update
    void Start()
    {
        secondsCounter = 0;             
        codigoTiempo= GameObject.Find("tiempo").GetComponent<tiempo>();       
        puntajes = GameObject.Find("objetoPuntaje").GetComponent<almacenaPuntajes>();
    }

    void Update()
    {                
        if (codigoTiempo.reloj==0)
        {          
            Debug.Log("ENTRA 1");
            metodoEspera();                
        }            
    }

    void metodoEspera()
    {
        Debug.Log(secondsCounter);
        secondsCounter += Time.deltaTime;
                
                if (secondsCounter>5 && secondsCounter < 5.1)
                {       
                     secondsCounter=0;                   
                     if(puntajes.jugador2==0)
                     {
                      SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
                     }                                       
                }                      
    }
}
