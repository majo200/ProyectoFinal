using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionAmarillo : MonoBehaviour
{
   public int amarillos;
   public int otros;
   public int final;
   public GameObject pez;
   public GameObject cañaAmarilla;

   void Start()
   {
       amarillos = 0;
       otros = 0;
       final = 0;
       cañaAmarilla = GameObject.Find("CañaAmarilla");

   }
   void OnTriggerEnter(Collider other)
   {
       //Output the Collider's GameObject's name
       Debug.Log("Pez Atrapado" + "\n");
       pez = other.gameObject;
       pez.SetActive(false);

       if (pez.tag == "Amarillo")
       {
           amarillos+= 2;
         
       }


       else
       {
           otros+=3;
       }


   }
   void Update()
   {
       if (amarillos == 14)
       {
           final = amarillos - otros;
           cañaAmarilla.SetActive(false);
       }
   }
}