using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beerPong : MonoBehaviour
{

    public GameObject pelota;
    public GameObject Flecha;
    public Rigidbody rigidPelota;
    public GameObject flechaIndicadora;
    public float rotacionY = 1.5f;
    public float rotacionZ = -0.35f;

    public bool valorXObtenido = false;
    public bool valorYObtenido = false;
    public bool pelotaLanzada = false;

    public float valorRotX;
    public float valorRotY;
    public float valorFuerzaX;
    public float valorFuerzaY;

    public int Puntaje = 0;
    public int Puntaje2 = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inicio Beer Pong");
        rigidPelota = pelota.GetComponent<Rigidbody>();
        Flecha = GameObject.Find("FlechaIndicadora");
    }

    // Update is called once per frame
    void Update()
    {
        if(valorXObtenido == false && valorYObtenido == false){
            //Rotando flecha en el eje X
            if(flechaIndicadora.transform.rotation.eulerAngles.y > 60 && flechaIndicadora.transform.rotation.eulerAngles.y < 75){
                rotacionY *= -1;
            }else if(flechaIndicadora.transform.rotation.eulerAngles.y > 270 && flechaIndicadora.transform.rotation.eulerAngles.y < 300){
                rotacionY *= -1;
            }
            flechaIndicadora.transform.Rotate(0, rotacionY, 0, Space.Self);
        }

        if(valorXObtenido == true){
            if(flechaIndicadora.transform.rotation.eulerAngles.z > 315 && flechaIndicadora.transform.rotation.eulerAngles.z < 345){
                rotacionZ *= -1;
            }else if(flechaIndicadora.transform.rotation.eulerAngles.z > 0 && flechaIndicadora.transform.rotation.eulerAngles.z < 15){
                rotacionZ *= -1;
            }
            flechaIndicadora.transform.Rotate(0,0,rotacionZ, Space.Self);
        }
        
        //obteniendo el valor de la fuerza del disparo en el eje y
        direccionEjeY();
        //Obteniendo el valor de la fuerza del disparo en el eje X
        direccionEjeX();
        //Lanzando pelota
        lanzarPelota();

    }

    //obtener la fuerza para aplicar en el eje x
    public void direccionEjeX(){
        
        if(Input.GetKeyDown(KeyCode.Space) && valorXObtenido == false){
            valorRotX = flechaIndicadora.transform.rotation.eulerAngles.y;
            if(valorRotX >= 0 && valorRotX <= 60){
                valorFuerzaX = (valorRotX * 9.11f)/60;
            }else{
                valorRotX = 360 - valorRotX;
                valorFuerzaX = ((valorRotX * 9.11f)/60) * -1;            
            }
            valorXObtenido = true;
            Debug.Log("El valor de la fuerza en X es: " + valorFuerzaX);
            Debug.Log("El valor de la rotacion en X es: " + valorRotX);
        }
    }

    //Obtener la fuerza para aplicar en el eje y
    public void direccionEjeY(){
        
        if(Input.GetKeyDown(KeyCode.Space) && valorYObtenido == false && valorXObtenido == true){
            valorRotY = flechaIndicadora.transform.rotation.eulerAngles.z;
            if(valorRotY >= 300 ){
                valorRotY = 360 - valorRotY;
                valorFuerzaY = ((valorRotY * 10.11f)/45);
            }
            valorYObtenido = true;
            Debug.Log("El valor de la fuerza en Y es: " + valorFuerzaY);
            Debug.Log("El valor de la rotacion en Y es: " + valorRotY);
        }
    }

    public void lanzarPelota(){
        if(Input.GetKeyDown(KeyCode.Space) && valorXObtenido == true && valorYObtenido == true && pelotaLanzada == false){
            rigidPelota.AddForce(-15,valorFuerzaY,valorFuerzaX,ForceMode.Impulse); 
            pelotaLanzada = true;
            Flecha.transform.rotation = Quaternion.Euler(0,0,0);
            Flecha.SetActive(false);
            valorRotX = 0;
            valorRotY = 0;
            valorFuerzaX = 0;
            valorFuerzaY = 0;

        }
    }
}

