using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBroken : MonoBehaviour
{
    [SerializeField]
    private Sprite brokenBrickSprite;
    private int count;

    private void Start() {
        count = 0;
    }
    
    /** 
        Detects if the brick gameobject has collided with the ball, if done so
        once (count = 1), the broken brick sprite will replace the current brick
        sprite. If count = 2, destroy this brick gameobject.


        @params {Collision2D} The Collision2D data associated with this collision.
    */
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball"){
            count++;
            if(count ==1){
                GetComponent<SpriteRenderer>().sprite = brokenBrickSprite;
            }else if(count == 2){
                Destroy(gameObject);
            }
        }    
    }
}
