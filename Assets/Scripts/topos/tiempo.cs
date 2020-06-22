using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
    public Text textoRELOJ;
    public float cont;
    public int reloj;
    
    void Start()
    {
       reloj=1;
       cont=60f;
    }

    // Update is called once per frame
    void Update()
    {
        
        cont-= Time.deltaTime;
       
        if(reloj!=0)
        {
         reloj = (int)cont;
         textoRELOJ.text = reloj.ToString();
        }
    }
}
