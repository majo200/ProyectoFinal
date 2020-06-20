using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class volverINICIO : MonoBehaviour
{
   public void volverInicio(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
