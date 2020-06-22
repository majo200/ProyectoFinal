﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaBeer : MonoBehaviour
{
    public beerPong scriptBeerPong;
    
    void OnCollisionEnter(Collision colision){
        if(colision.gameObject.tag == "pong"){
            scriptBeerPong.Puntaje++;
            colision.gameObject.SetActive(false);
            this.gameObject.transform.position = new Vector3(3.7f, 6.2f, 2.11f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
        }else if(colision.gameObject.tag == "pong2"){
            scriptBeerPong.Puntaje2++;
            colision.gameObject.SetActive(false);
            this.gameObject.transform.position = new Vector3(3.7f, 6.2f, 2.11f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
        }else if(colision.gameObject.tag == "suelo"){
            this.gameObject.transform.position = new Vector3(3.7f, 6.2f, 2.11f);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scriptBeerPong.valorXObtenido = false;
            scriptBeerPong.valorYObtenido = false;
            scriptBeerPong.pelotaLanzada = false;
            scriptBeerPong.Flecha.SetActive(true);
        }
    }
}
