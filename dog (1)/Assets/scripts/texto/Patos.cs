using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Patos : MonoBehaviour {
    public Text patosLabel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        patosLabel.text = Gamemanage.compartido.pato.ToString();
    }
}
