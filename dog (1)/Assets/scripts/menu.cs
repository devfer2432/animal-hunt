using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        print("cambiando a la escena" + nombre);
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        print("saliendo del juego");
        Application.Quit();
    }

}
