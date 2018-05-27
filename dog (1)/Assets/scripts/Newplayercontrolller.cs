using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newplayercontrolller : MonoBehaviour {
    private Rigidbody2D perro; 
    private float axis;
    public float maxvel = 15.0f;
    bool volteo= true;
    private SpriteRenderer perrorender;
    private Animator perroAnim;
    public float fuerzaDeSalto = 6.0f;
    public float rashoLazer = 1.0f;
    private Rigidbody2D rigidbody;
    public LayerMask groundLayerMask;
    public int c;
    private Transform l;
    public static Newplayercontrolller compart;
    private Transform a;
    Vector2 pos;
    //Despertar
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        perroAnim =GetComponent<Animator>();
        compart = this;
        l = GetComponent<Transform>();
    }
    //Empezar
    void Start () {
        perro = GetComponent<Rigidbody2D>();
        perrorender = GetComponent<SpriteRenderer>();
       
    }

    // Actualizar
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Saltar();
        }
        axis = Input.GetAxis("Horizontal");
            if (axis > 0 && !volteo)
            {
                Volteo();
            }
            if (axis < 0 && volteo)
            {
                Volteo();
            }
            perro.velocity = new Vector2(axis * maxvel, perro.velocity.y);
            perroAnim.SetFloat("transition", Mathf.Abs(axis));
    }
    //para saltar 
    void Saltar()
    {
        if (IsOnTheFloor())
        {
            rigidbody.AddForce(Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
            Debug.Log("esta saltando");
        }
    }
    //voltear 180°
    void Volteo()
    {
        volteo = !volteo;
        perrorender.flipX = !volteo;

    }
    //retornar un valor booleano cuando detecte un terrero de tipo groundlayermask 
    
    bool IsOnTheFloor()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, rashoLazer, groundLayerMask.value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   public void Dead()
    {
        pos = transform.position;
        pos.x -= 11f;
        pos.y += 5;
        transform.position = pos;
        
    }
}






















































































































































































































































































































































//querido fernando si estas leyendo esto significa que volviste a hacer el codigo ;) , te recomiendo que te vallas a la chingada madre por que fue muy dicil , vago de mierda,hail grasa atte tu puta madre azopotamadre