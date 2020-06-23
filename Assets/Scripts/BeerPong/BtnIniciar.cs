using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnIniciar : MonoBehaviour
{
    public void btnCambiarBeerPong(){
        SceneManager.LoadScene("beerpong");
    }
}
