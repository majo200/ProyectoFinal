using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class b_SeleccionCaña : MonoBehaviour
{
    
    public GameObject cañaRoja;
    public GameObject cañaVerde;
    public GameObject cañaAmarilla;
    public GameObject miPanel;
    public Image punt_A;
    public Image punt_V;
    public Image punt_R;
    public string cañaSeleccionada;
    public GameObject panelControl;

    void Start()
    {   

        cañaVerde = GameObject.Find("CañaVerde");
        cañaVerde.SetActive(false);

        cañaAmarilla = GameObject.Find("CañaAmarilla");
        cañaAmarilla.SetActive(false);

        cañaRoja = GameObject.Find("CañaRoja");
        cañaRoja.SetActive(false);

        miPanel = GameObject.Find("miPanel");

        punt_A.enabled = false;
        punt_V.enabled = false;
        punt_R.enabled = false;      

        cañaSeleccionada="";

        panelControl= GameObject.Find("panel_Teclado");
        panelControl.SetActive(false);
    }

 
    public void verde()
    {
        miPanel.SetActive(false);
        cañaVerde.SetActive(true);
        punt_V.enabled = true;
        panelControl.SetActive(true);
        cañaSeleccionada="Verde";

    }

    public void rojo()
    {
        miPanel.SetActive(false);
        cañaRoja.SetActive(true);
        punt_R.enabled = true;
        panelControl.SetActive(true);
        cañaSeleccionada="Rojo";
    }

    public void amarillo()
    {
        miPanel.SetActive(false);
        cañaAmarilla.SetActive(true);
        punt_A.enabled = true;
        panelControl.SetActive(true);
        cañaSeleccionada="Amarillo";
    }
}
