using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    public Vector3 reset_position = Vector3.zero;
    public Rigidbody rb;
    public Transform player;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name); // we can change name to see information about

        if (other.collider.name.ToLower().Contains("obstacle"))
        {
            player.position = reset_position;
            rb.velocity = Vector3.zero;
            // reset poisition after a certain distance

        }

        if (other.collider.name.ToLower().Contains("ground"))
        {
            rb.velocity = new Vector3(rb.velocity[0], (float) 0.0, (float) 0.0);
        }
        
        // We can use unity to group stuff by tugs, and then use a script to get the tag of what
        // we are colliding with
        
        // Debug.Log(other.collider.tag);
        
    }
}
