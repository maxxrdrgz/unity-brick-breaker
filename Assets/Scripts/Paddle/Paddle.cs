﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    /** 
        Gets horizontal input from the player. Moves the paddle gameobjects x
        position left and right
    */
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");   
        if(h > 0){
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }
        if(h<0){
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
}
