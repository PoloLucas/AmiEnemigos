using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
   public void EscenaJuego()
    {
        SceneManager.LoadScene("Historia");
    }

    
    public void Salir()
    {
        Application.Quit();
    }

}
