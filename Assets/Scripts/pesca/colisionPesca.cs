using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionPesca : MonoBehaviour
{
   public int rojos;
   public int otros;
   public int final;
   public GameObject pez;
   public GameObject cañaRoja;

   void Start()
   {
       rojos = 0;
       otros = 0;
       final = 0;
       cañaRoja = GameObject.Find("CañaRoja");
       
   }
   void OnTriggerEnter(Collider other)
   {
       //Output the Collider's GameObject's name
       Debug.Log("Pez Atrapado" + "\n");
       pez = other.gameObject;
       pez.SetActive(false);

       if (pez.tag=="Rojo")
       {
           rojos+=2;
       }
         

       else
       {
           otros+=3;
       }

       
   }
   void Update()
   {
       if (rojos == 14)
       {
           final = rojos - otros;
           cañaRoja.SetActive(false);
       }
   }
}
