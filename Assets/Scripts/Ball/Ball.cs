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
    private void Start() {
        rbody.velocity = Vector2.up * speed;
    }

    float WhereToGo(Vector2 ballPos, Vector2 paddlePos){
        return ballPos.x - paddlePos.x;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Paddle"){
            float x = WhereToGo(transform.position, other.transform.position);
            Vector2 dir = new Vector2(x, 1);
            rbody.velocity = dir * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bottom"){
            Destroy(gameObject);
        }
    }
}
