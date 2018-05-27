using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class raton : MonoBehaviour {

    public string nombre;
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            print("cambiando a la escena" + nombre);
            SceneManager.LoadScene(nombre);

        }
    }
}
