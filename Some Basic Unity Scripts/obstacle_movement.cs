using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// walls are at 0.5 and 29.5
public class obstacle_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb_obstacle;
    public Vector3 obstacle_intial_velocity;
    public Vector3 pos;
    public Vector3 prev_velocity;
    public float obstacle_speed = 40;
    void Start()
    {
        rb_obstacle.velocity = obstacle_intial_velocity;
        prev_velocity = rb_obstacle.velocity;
    }

    private void OnCollisionEnter(Collision other)
    {
        var vel = rb_obstacle.velocity;

        pos = rb_obstacle.position;

        if (prev_velocity[0] > 0)
        {
            rb_obstacle.velocity = new Vector3( -obstacle_speed, (float) 0.0, (float) 0.0);
        }
        if (prev_velocity[0] < 0)
        {
            rb_obstacle.velocity = new Vector3( obstacle_speed, (float) 0.0, (float) 0.0);
        }

        prev_velocity = rb_obstacle.velocity;

    }

    // Update is called once per frame
    // void Update()
    // {
    //     pos = rb_obstacle.position;
    //     if (pos[0] > 27)
    //     {
    //         rb_obstacle.velocity = new Vector3((float) -40.0, (float)0.0, (float)0.0);
    //         //rb_obstacle.AddForce(0, 0, -100);
    //     }
    //     if (pos[0] < 3)
    //     {
    //         rb_obstacle.velocity = new Vector3((float) 40.0,(float) 0.0, (float)0.0);
    //
    //         //rb_obstacle.AddForce(0, 0, 1100);
    //     }
    //     
    //     // introduce logic to prevent obstacle getting stuck
    //     // add life counter - if you get hit 3 times, go back to the beginning 
    //     // change it so that it is on the basis of collision with the side not on poistion
    //     // this will make adding more obstacles easier
    //     
    //     // var velocity = rb_obstacle.velocity;
    //     // velocity[1] = (float) 0;
    //     // velocity[2] = (float) 0;
    //     // rb_obstacle.velocity = velocity;
    
}
