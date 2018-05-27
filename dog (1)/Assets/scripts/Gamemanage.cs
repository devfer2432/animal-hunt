using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanage : MonoBehaviour {
    public static Gamemanage compartido;
    public int monedas = 0;
    public int pato = 0;
    public int hueso = 0;
    public int monedasNecesariasParaElMuro = 0;
    public int patosNecesariosParaElHueso = 0;
    public int finalh = 0;
    public int finalp = 0;
    public string nombre; 
    private void Awake()
    {
        compartido = this;
    }
    public void Update()
    {
        if ((pato == finalp) && (hueso == finalh))
        {
            SceneManager.LoadScene(nombre);
            print("final de la escena ");
        }
    }
    public void MonedasRecogidas()
    {
        monedas++;
        Debug.Log("moneda: " + monedas);
    }
    public void PatoRecogido()
    {
        pato++;
    }
    public void HuesoRecogido()
    {
        hueso++;
    }
    public void GameOver()
    {
        monedas = 0;
        pato = 0;
        Monedita.share.ShowCoin();
        Pato.share1.ShowPato();
    }
}
