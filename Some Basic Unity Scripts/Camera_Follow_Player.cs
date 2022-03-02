using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Camera_Follow_Player : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public Vector3 fixed_offset;
    // private Vector3 player_previous_position;
    public Vector3 dynamic_offset, player_velocity;
    public Rigidbody player_rb;
    public float dynamic_change;
    public float dynamic_limit;
    [FormerlySerializedAs("dynamic_limit")] public float dynamic_begin;

    private void Start()
    {
        fixed_offset = new Vector3(0, 1, -3);
        // player_previous_position = player.position;
        dynamic_begin = (float) 0.1;
        dynamic_change = (float) 0.1;  // 0.001
        dynamic_limit = (float) 0.8;
    } 

    void FixedUpdate()
    {
        // when writing transform without a capital t we are referring to the object that the script
        // is sitting on

        // Vector3 change_in_player_position = player.position - player_previous_position;
        
        player_velocity = player_rb.velocity;

        if (player_velocity[0] > dynamic_begin)
        {
            if (dynamic_offset[0] > -dynamic_limit)
                
            {
                dynamic_offset[0] = dynamic_offset[0] - dynamic_change;
            }
        }
        if (player_velocity[0] < -dynamic_begin)
        {
            if (dynamic_offset[0] < dynamic_limit)
                
            {
                dynamic_offset[0] = dynamic_offset[0] + dynamic_change;
            }
        }
        
        if (player_velocity[1] > dynamic_begin)
        {
            if (dynamic_offset[1] > -dynamic_limit)
            {
                dynamic_offset[1] = dynamic_offset[1] - dynamic_change;
            }
        }
        if (player_velocity[1] < -dynamic_begin)
        {
            if (dynamic_offset[1] < dynamic_limit)
                
            {
                dynamic_offset[1] = dynamic_offset[1] + dynamic_change;
            }
        }
        
        if (player_velocity[2] > dynamic_begin)
        {
            if (dynamic_offset[2] > -dynamic_limit)
            {
                dynamic_offset[2] = dynamic_offset[2] - dynamic_change;
            }
        }
        if (player_velocity[2] < - dynamic_begin)
        {
            if (dynamic_offset[2] < dynamic_limit/10)
                
            {
                dynamic_offset[2] = dynamic_offset[2] + dynamic_change;
            }
        }
        
        // get it to rotate around the player

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (camera.rotation[0] <= 30)
            {
                transform.Rotate(Vector3.right, 10.0f * Time.deltaTime);
            }
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left, 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 10.0f * Time.deltaTime);
        }
        
        // make it so the player can stick to the side


        transform.position = player.position + fixed_offset + dynamic_offset;
    }
}
