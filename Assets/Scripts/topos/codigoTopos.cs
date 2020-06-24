using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class codigoTopos : MonoBehaviour
{
    //METODO PARA SUBIR Y BAJAR LOS TOPOS ALEATORIAMENTE
    //Declaramos los objetos de la escena
    public GameObject topo1;
    public GameObject topo2;
    public GameObject topo3;
    public GameObject topo4;  
    //Variable para almacenar número aleatorio
    public int aleatorio;   
    //Variable para saber si el topo ya subió y bajó
    public string estado;   
     //Variable que utilizaremos para la espera
    float secondsCounter;    
   

    void Start()
    {
        //Para que las encuentre en la escena
        topo1 = GameObject.Find("topo1");
        topo2 = GameObject.Find("topo2");
        topo3 = GameObject.Find("topo3");
        topo4 = GameObject.Find("topo4");
        //todos los aleatorios comienzan en 0
        aleatorio=0;
        //El estado inicia en subiendo
        estado="subiendo";  
        secondsCounter = 0;    
    }

    
    void Update()
    {          
      //Se genera un número aleatorio cuando ningún topo esté saliendo 
      if(aleatorio!=1 && aleatorio!=2 && aleatorio!=3 && aleatorio!=4 )
      {
            aleatorio= Random.Range(1,10);
            Debug.Log(aleatorio);
      }

        //Si el aleatorio es 1, sube el topo 1
        else if(aleatorio==1)
        {
            if(estado=="subiendo")
            {
                metodoSUBIR(topo1);
            }
            else if(estado=="bajando")
            {
                metodoBAJAR(topo1);
            }                 
        }
        
        //Si el aleatorio es 2, sube el topo 2
        else if(aleatorio==2)
        {
               if(estado=="subiendo")
            {
                metodoSUBIR(topo2);
            }
            else if(estado=="bajando")
            {
                metodoBAJAR(topo2);
            }                     
        }

        //Si el aleatorio es 3, sube el topo 3        
        else if(aleatorio==3)
        {
              if(estado=="subiendo")
            {
                metodoSUBIR(topo3);
            }
            else if(estado=="bajando")
            {
                metodoBAJAR(topo3);
            }                
        }

        //Si el aleatorio es 4, sube el topo 4
        else if(aleatorio==4)
        {
            if(estado=="subiendo")
            {
                metodoSUBIR(topo4);
            }
            else if(estado=="bajando")
            {
                metodoBAJAR(topo4);
            }     
        }              
    }        

       void metodoSUBIR(GameObject topo)
    {            
        Debug.Log(secondsCounter);
        secondsCounter += Time.deltaTime;
              
        topo.transform.position += transform.up * (Time.deltaTime);  
                    
         if (secondsCounter>1.5)
         {    
          secondsCounter=0;  
          estado="bajando"; 
         }
    }    

    void metodoBAJAR(GameObject topo)
    {
        secondsCounter += Time.deltaTime;

        topo.transform.position -= transform.up * (Time.deltaTime);
        
        if (secondsCounter>1.5)
        {       
          secondsCounter=0;           
          estado="subiendo";
          aleatorio=0;
        }
    }
}
