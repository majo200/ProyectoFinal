using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class volverINICIO : MonoBehaviour
{
    //Al presionar el botón se cargará la escena que esté escrita
   public void volverInicio(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
