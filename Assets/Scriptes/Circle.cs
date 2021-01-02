using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	public Score score;
	public float speedJump;
	public float speedMovement;
	private Rigidbody2D rb;
	
	private bool isOver;

    void Start()
    {
        rb.gravityScale=0;
    }

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if((Input.GetButtonDown("Fire1") | Input.GetKey("space")) & !isOver){
        
        	rb.velocity = new Vector2 (rb.velocity.x, speedJump);
        	rb.gravityScale=1;
        	score.scoreUp();
        }

        if(rb.gravityScale>0)
          transform.Translate(-Vector2.left*speedMovement*Time.deltaTime);
    }



    void OnTriggerEnter2D(Collider2D other){
    	if(other.tag=="traject"){
    		rb.velocity= Vector3.zero;
    		rb.gravityScale=0;
    		isOver = true;
    		score.setHighScore();
    		UI.instance.activePanel();
    	}
    }


}
