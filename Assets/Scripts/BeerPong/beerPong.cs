using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beerPong : MonoBehaviour
{

    public GameObject pelota;
    public GameObject Flecha;
    public Rigidbody rigidPelota;
    public GameObject flechaIndicadora;
    public float rotacionY = 4f;
    public float rotacionZ = -1f;

    public bool valorXObtenido = false;
    public bool valorYObtenido = false;
    public bool pelotaLanzada = false;

    public float valorRotX;
    public float valorRotY;
    public float valorFuerzaX;
    public float valorFuerzaY;

    public int Puntaje = 0;
    public int Puntaje2 = 0;

    public GameObject b_x;
    public GameObject b_y;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inicio Beer Pong");
        rigidPelota = pelota.GetComponent<Rigidbody>();
        rigidPelota.isKinematic = true;
        Flecha = GameObject.Find("FlechaIndicadora");
        b_x = GameObject.Find("x");
        b_y = GameObject.Find("y");
        b_y.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(valorXObtenido == false && valorYObtenido == false){
            //Rotando flecha en el eje X
            if(flechaIndicadora.transform.localRotation.eulerAngles.y > 60 && flechaIndicadora.transform.localRotation.eulerAngles.y < 75){
                rotacionY *= -1;
            }else if(flechaIndicadora.transform.localRotation.eulerAngles.y > 270 && flechaIndicadora.transform.localRotation.eulerAngles.y < 300){
                rotacionY *= -1;
            }
            flechaIndicadora.transform.Rotate(0, rotacionY, 0, Space.Self);
        }

        if(valorXObtenido == true){
            if(flechaIndicadora.transform.localRotation.eulerAngles.z > 315 && flechaIndicadora.transform.localRotation.eulerAngles.z < 345){
                rotacionZ *= -1;
            }else if(flechaIndicadora.transform.localRotation.eulerAngles.z > 0 && flechaIndicadora.transform.localRotation.eulerAngles.z < 15){
                rotacionZ *= -1;
            }
            flechaIndicadora.transform.Rotate(0,0,rotacionZ, Space.Self);
        }
    }

    //obtener la fuerza para aplicar en el eje x
    public void direccionEjeX(){
        
        
            valorRotX = flechaIndicadora.transform.localRotation.eulerAngles.y;
            if(valorRotX >= 0 && valorRotX <= 60){
                valorFuerzaX = (valorRotX * 9f)/60;
            }else{
                valorRotX = 360 - valorRotX;
                valorFuerzaX = ((valorRotX * 9f)/60) * -1;            
            }
            valorXObtenido = true;
            Debug.Log("El valor de la fuerza en X es: " + valorFuerzaX);
            Debug.Log("El valor de la rotacion en X es: " + valorRotX);
        b_x.SetActive(false);
        b_y.SetActive(true);
        
    }

    //Obtener la fuerza para aplicar en el eje y
    public void direccionEjeY(){
        
            valorRotY = flechaIndicadora.transform.localRotation.eulerAngles.z;
            if(valorRotY >= 300 ){
                valorRotY = 360 - valorRotY;
                valorFuerzaY = ((valorRotY * 10)/45);
            }
            valorYObtenido = true;
            Debug.Log("El valor de la fuerza en Y es: " + valorFuerzaY);
            Debug.Log("El valor de la rotacion en Y es: " + valorRotY);        
        lanzarPelota();
            
    }

    public void lanzarPelota(){

            rigidPelota.isKinematic = false;
            rigidPelota.AddRelativeForce(-15f,valorFuerzaY,valorFuerzaX,ForceMode.Impulse); 
            Debug.Log("Lanzada Relativa: " + valorFuerzaX + " , " + valorFuerzaY);
            pelotaLanzada = true;
            Flecha.transform.localRotation = Quaternion.Euler(0,0,0);
            Flecha.SetActive(false);
            valorRotX = 0;
            valorRotY = 0;
            valorFuerzaX = 0;
            valorFuerzaY = 0;
        b_x.SetActive(true);
        b_y.SetActive(false);

    }
}

