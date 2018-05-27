using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    public float fuerzaDeSalto = 6.0f;
	public float velocidad = 1.0f;
	public float rashoLazer= 1.0f;
	public float maxvel = 2.0f;
    private Rigidbody2D rigidbody;
    private Rigidbody2D rb;
    public LayerMask groundLayerMask;
    // Use this for initialization
    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();

    }
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            Saltar();
        }
        
    }
     void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
		rigidbody.AddForce(Vector2.right * velocidad * h);
		if(rigidbody.velocity.x>maxvel){
			rigidbody.velocity = new Vector2 (maxvel, rigidbody.velocity.y);
		}
		if(rigidbody.velocity.x<-maxvel){
			rigidbody.velocity = new Vector2 (-maxvel, rigidbody.velocity.y);
		}
    }
    //para saltar :v
    void Saltar()
	{
		if (IsOnTheFloor ()) {
			rigidbody.AddForce (Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
			Debug.Log ("esta saltando");
		}
	}
    //para que no hubiera el bug "flappy bird "
	bool IsOnTheFloor(){
		if (Physics2D.Raycast (this.transform.position, Vector2.down, rashoLazer, groundLayerMask.value)) {
			return true;
		} else {
			return false;
		}
	}
    }
