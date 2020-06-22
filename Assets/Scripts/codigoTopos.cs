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
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        //Para que las encuentre en la escena
        topo1 = GameObject.Find("topo1");
        topo2 = GameObject.Find("topo2");
        topo3 = GameObject.Find("topo3");
        topo4 = GameObject.Find("topo4");
        //todos los aleatorios comienzan en 0
        aleatorio=0;
        estado="subiendo";    
        
    }

    // Update is called once per frame
    void Update()
    {
          
      //Se genera un número aleatorio cuando ningún topo esté saliendo 
      if(aleatorio!=1 && aleatorio!=2 && aleatorio!=3 &&aleatorio!=4)
      {
            aleatorio= Random.Range(1,10);
            Debug.Log(aleatorio);
      }

        //Si el aleatorio es 1, sube el topo 1
        else if(aleatorio==1)
        {
            //Este contador se utiliza para comprobar que ya el topo realizó todo el camino 
            if(contador<210)
            {
                 contador += subirOBajar(topo1);             
            }

            //Cuando ya ha finalizado el camino, significa que un nuevo topo podrá subir
            else
            {
                contador=0;
                aleatorio=0;
                estado="subiendo";
            }        
          
        }
        
        //Si el aleatorio es 2, sube el topo 2
        else if(aleatorio==2)
        {
            if(contador<210)
            {
                 contador += subirOBajar(topo2);
            }
            else
            {
                contador=0;
                aleatorio=0;
                estado="subiendo";
            }
                  
        }

        //Si el aleatorio es 3, sube el topo 3        
        else if(aleatorio==3)
        {
            if(contador<210)
            {
                 contador += subirOBajar(topo3);
            }
            else
            {
                contador=0;
                aleatorio=0;
                estado="subiendo";
            }
            
        }

        //Si el aleatorio es 4, sube el topo 4
        else if(aleatorio==4)
        {
            if(contador<210)
            {
                 contador += subirOBajar(topo4);
            }
            else
            {
                contador=0;
                aleatorio=0;
                estado="subiendo";
            }
          
        }      
        
    }

    //Este es el método que nos permite cambiar la posición del topo
    public int subirOBajar(GameObject topo)
    {
        //El contador siempre va a ser uno, se va sumando arriba
      int cont=1;
        
            //si el topo no ha subido del todo, siga subiendo
            if (topo.transform.position.y <6.29f && estado.Equals("subiendo"))
            {
               topo.transform.localPosition += increaseValues * (Time.deltaTime/100);   
            } 
       
            //El topo baja
            else if(topo.transform.position.y >4.91f )
            {
               topo.transform.localPosition -= increaseValues * (Time.deltaTime/100);
               estado="bajando";
            }
            
    //Me devuelve el contador para irlo sumando
    return cont;
    }
    
}
