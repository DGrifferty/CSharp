using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat_Follow_Ball : MonoBehaviour
{
    public Transform player;
    public Vector3 Hat_offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Hat_offset;
    }
}
