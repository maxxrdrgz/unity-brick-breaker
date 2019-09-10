using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    /** 
        Moves the gameobjects rigid bodies velocity in the up driection
    */
    private void Start() {
        rbody.velocity = Vector2.up * speed;
    }

    /** 
        Returns the difference between the balls x position and the paddles x
        position.

        @{params} {Vector2} position of the ball
        @{params} {Vector2} position of the paddle
    */
    float WhereToGo(Vector2 ballPos, Vector2 paddlePos){
        return ballPos.x - paddlePos.x;
    }

    /** 
        Detects collision with the paddle. Calculates the x direction the ball
        should go and changes it's rigid bodies velocity

        @params {Collision2D} The Collision2D data associated with this collision.
    */
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Paddle"){
            float x = WhereToGo(transform.position, other.transform.position);
            Vector2 dir = new Vector2(x, 1);
            rbody.velocity = dir * speed;
        }
    }

    /** 
        Detects if the ball has collided with the "Bottom" collider. Bottom
        being an invisible collider that despawns objects.

        @params {Collider2D} The other Collider2D involved in this collision.
    */
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bottom"){
            Destroy(gameObject);
        }
    }
}
