using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pato : MonoBehaviour {
    bool isCollected = false;
    public static Pato share1;
    private void Start()
    {
        share1 = this;
    }
    public void ShowPato()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<CircleCollider2D>().enabled = true;
    }
    void HidePato()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<CircleCollider2D>().enabled = false;
        Gamemanage.compartido.PatoRecogido ();

    }
    void CollectPato()
    {
        isCollected = true;
        HidePato();
    }
    private void OnTriggerEnter2D(Collider2D otherCollider2)
    {
        if (otherCollider2.tag == "Player")
        {
            CollectPato();
        }
    }

}
