using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaBeer : MonoBehaviour
{
    public beerPong scriptBeerPong;
    
    void OnCollisionEnter(Collision colision){
        if(colision.gameObject.tag == "pong"){
            scriptBeerPong.Puntaje++;
            colision.gameObject.SetActive(false);
            this.gameObject.transform.localPosition = new Vector3(6.110001f, 6.463001f, 0.3699999f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }else if(colision.gameObject.tag == "pong2"){
            scriptBeerPong.Puntaje2++;
            colision.gameObject.SetActive(false);
            this.gameObject.transform.localPosition = new Vector3(6.110001f, 6.463001f, 0.3699999f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }else if(colision.gameObject.tag == "suelo"){
            this.gameObject.transform.localPosition = new Vector3(6.110001f, 6.463001f, 0.3699999f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
