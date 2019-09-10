using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    /** 
        Detects if the brick gameobject has collided with the ball, if so, the
        brick gameobject gets destroyed

        @params {Collision2D} The Collision2D data associated with this collision.
    */
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball"){
            DestroyObject(gameObject);
        }
    }
}
