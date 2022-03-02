using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;
using Random = System.Random;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public int movement_speed = 100;
    public Transform player;
    public Vector3 reset_position = Vector3.zero;
    public double gravity = 9.8;
    public bool use_gravity = true;
    // Start is called before the first frame update
    
    Random rnd = new Random();
    void Start()
    {
        Console.WriteLine("Runs on start of the program");
        Debug.Log("Runs at the start of the program");
        
        // changing properties of this class instance of the rigid body
        // as selected in unity

        rb.useGravity = use_gravity;
        // rb.AddForce(0, 0, 0);

    }

    // private void Update()
    // {
    //     if (rb.velocity[1] > 0)
    //     {
    //         rb.velocity[1] = rb.velocity[1] + -gravity * Time.deltaTime;
    //         
    //     }
    // }

    // Update is called once per frame
    void FixedUpdate() 
    {
        // int dvx = rnd.Next(-1000, 1000);
        // int dvy = rnd.Next(-1000, 1000);
        // int dvz = rnd.Next(-1000, 1000);
        // rb.AddForce(dvx * Time.deltaTime, dvy * Time.deltaTime, dvz * Time.deltaTime);
        

        
        if (Input.GetKey("d"))
        {
            //moving right

            rb.AddForce(movement_speed * Time.deltaTime + 17, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            // moving left
            
            rb.AddForce(-movement_speed *Time.deltaTime - 17, 0, 0);
        }
        
        if (Input.GetKey("w"))
        {
            // Moving forward
            rb.AddForce(0, 0, movement_speed *Time.deltaTime + 17);
        }
        if (Input.GetKey("s"))
        {
            // Moving backward
            rb.AddForce(0, 0, -movement_speed *Time.deltaTime - 17);
        }

        if (Input.GetKey("r"))
        {
            player.position = reset_position;
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKey("f"))
        {
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKey("space"))
        {
            if (rb.position[1] < 6.1)
            {
                rb.velocity = new Vector3((float) rb.velocity[0], (float) 8.0, (float) 0.0);
            }
        }
        
    }
}
