using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class codigoTopos : MonoBehaviour
{
    //Declaramos los objetos de la escena
    public GameObject topo1;
    public GameObject topo2;
    public GameObject topo3;
    public GameObject topo4;

    //Variable que guardará el puntaje
    
    public int aleatorio;
   public Vector3 increaseValues = new Vector3(0, 0.01f,0);
    public string estado;
    // Start is called before the first frame update
    void Start()
    {
        //Para que las encuentre en la escena
        topo1 = GameObject.Find("topo1");
        topo2 = GameObject.Find("topo2");
        topo3 = GameObject.Find("topo3");
        topo4 = GameObject.Find("topo4");
        //todos los aleatorios comienzan en 3
        aleatorio=0;
         estado="subiendo";    
    }

    // Update is called once per frame
    void Update()
    {
           Debug.Log(aleatorio);
        //subirOBajar(topo1);
        //subirOBajar(topo2);
        //subirOBajar(topo3);
        //subirOBajar(topo4);
        //if(aleatorio==0)
           // {
            //  aleatorio= Random.Range(1,4);
          //    estado="subiendo";
          //  }
        
       // if(aleatorio ==1)
        //{
          
            Debug.Log("SUBE 1");
             while (topo1.transform.position.y <6.29f && estado.Equals("subiendo"))
              {
                Debug.Log("entra");
               topo1.transform.localPosition += increaseValues * (Time.deltaTime/100);      
                Debug.Log(topo1.transform.localPosition.y);
              } 
       
              while(topo1.transform.position.y >4.91f )
              {
                Debug.Log("entra");
               topo1.transform.localPosition -= increaseValues * (Time.deltaTime/100);
               estado="bajando";
              }

              
               aleatorio=0;
               Debug.Log("Ya subio");
            estado="subiendo";
        /*
       // }

       // else if(aleatorio==2)
        //{
            
            Debug.Log("SUBE 2");
              if(topo2.transform.position.y <6.29f && estado.Equals("subiendo"))
              {
                Debug.Log("entra");
               topo2.transform.localPosition += increaseValues * (Time.deltaTime/100);
                Debug.Log(topo2.transform.localPosition.y);
              }
       
              else if(topo2.transform.position.y >4.91f )
              {
                Debug.Log("entra");
               topo2.transform.localPosition -= increaseValues * (Time.deltaTime/100);
               estado="bajando";
              }

              aleatorio=0;
              Debug.Log("Ya subio");
              
        //}

        
        //else if(aleatorio==3)
        //{    
            Debug.Log("SUBE 3");
              if(topo3.transform.position.y <6.29f && estado.Equals("subiendo"))
              {
                Debug.Log("entra");
               topo3.transform.localPosition += increaseValues * (Time.deltaTime/100);
               Debug.Log(topo3.transform.localPosition.y);
              }
       
              else if(topo3.transform.position.y >4.91f )
              {
                Debug.Log("entra");
               topo3.transform.localPosition -= increaseValues * (Time.deltaTime/100);
               estado="bajando";
              }

              
              aleatorio=0;
                Debug.Log("Ya subio");
            
        //}

        
       // else if(aleatorio==4)
        //{
            Debug.Log("SUBE 4");
           
              if(topo4.transform.position.y <6.29f && estado.Equals("subiendo"))
              {
                Debug.Log("entra");
                topo4.transform.localPosition += increaseValues * (Time.deltaTime/100);
               Debug.Log(topo4.transform.localPosition.y);
               
              }
       
              else if(topo4.transform.position.y >4.91f )
              {
                Debug.Log("entra");
               topo4.transform.localPosition -= increaseValues * (Time.deltaTime/100);
               estado="bajando";
              }

              
              aleatorio=0;
                Debug.Log("Ya subio");
              
        //}

        


    */   
    }
    

    
}
