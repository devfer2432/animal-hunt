using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texto : MonoBehaviour {
    public Text coinsLabel; 
	// Update is called once per frame
	void Update () {
        coinsLabel.text = Gamemanage.compartido.monedas.ToString();

    }
}
