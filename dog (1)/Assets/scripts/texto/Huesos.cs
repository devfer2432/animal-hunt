using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Huesos : MonoBehaviour {
    public Text HuesosLabel;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HuesosLabel.text = Gamemanage.compartido.hueso.ToString();

    }
}
