using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionVerde : MonoBehaviour
{
   public int verdes;
   public int otros;
   public int final;
   public GameObject pez;
   public GameObject cañaVerde;

   void Start()
   {
       verdes = 0;
       otros = 0;
       final = 0;
       cañaVerde = GameObject.Find("CañaVerde");
       
   }
   void OnTriggerEnter(Collider other)
   {
       //Output the Collider's GameObject's name
       Debug.Log("Pez Atrapado" + "\n");
       pez = other.gameObject;
       pez.SetActive(false);

       if (pez.tag=="Verde")
       {
           verdes+=2;
       }
         

       else
       {
           otros+=3;
       }

       
   }
   void Update()
   {
       if (verdes == 14)
       {
           final = verdes - otros;
           cañaVerde.SetActive(false);
       }
   }
}