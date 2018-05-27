using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hueso : MonoBehaviour {
    bool isCollected = false;
    public static Hueso share;
    private void Start()
    {
        share = this;
    }
    public void ShowHueso()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<PolygonCollider2D>().enabled = true;
    }
    void HideHueso()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<PolygonCollider2D>().enabled = false;
        Gamemanage.compartido.HuesoRecogido();
    }
    void CollectHueso()
    {
        isCollected = true;
        HideHueso();
    }
    private void OnTriggerEnter2D(Collider2D otherCollider1)
    {
        if (otherCollider1.tag == "Player")
        {
            CollectHueso();
        }
    }
}
