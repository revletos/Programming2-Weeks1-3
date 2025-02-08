using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float speed = 1.0f; // Can be set in inspector to adjust values
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position; // Much of this code is similar to the code from Week 1 of moving the square but instead of converting world space to screenspace to set boundaries, the boundaries are arbritarily and irregularly set off screen to give the illusion of clouds spawning and despawning
        pos.x += speed * Time.deltaTime; // Have the cloud speed move in delta time for a consistent performance across all computers
        //Debug.Log(pos.x.ToString());

        if ((pos.x > 13) || (pos.x < -15)) //If the cloud reaches a boundary that was set by eyeballing in Unity editor (does not have to be exact just a chunk bigger than the camera frame)
        {
            speed = speed * -1; // Change the direction of the speed by inverting it
        }
        transform.position = pos; // Update cloud position
    }
}
