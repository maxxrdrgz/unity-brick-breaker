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
