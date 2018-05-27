using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedita : MonoBehaviour {
    bool isCollected = false;
    public static Monedita share;
    private void Start()
    {
        share = this;
    }
  public void ShowCoin()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<CircleCollider2D>().enabled = true;
    }
    void HideCoin()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<CircleCollider2D>().enabled = false;
        Gamemanage.compartido.MonedasRecogidas();
        
    }
    void CollectCoin ()
    {
        isCollected = true;
        HideCoin ();
    }
    private void OnTriggerEnter2D(Collider2D otherCollider1)
    {
         if (otherCollider1.tag == "Player")
        {
            CollectCoin();
        }
    }
}
