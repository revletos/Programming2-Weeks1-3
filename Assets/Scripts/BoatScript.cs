using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
    public float speed = 1f; // Can be set in inspector to adjust values
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; // Keeps the value of the boat at the same level
                        // Probably unncessary but I used it when I was debugging with exclusively with Vector3
        mousePos.y = -1.6f; // Keeps the value of the boat at the same level

        transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);  //So the boat moves towards mouse position but only the x value
        //More detail: moves from transform position (current location) to x mouse position at a speed that should be universal accross all computers
        //I used about 3 different ways to try and write this code based on pseudocode provided but they didn't work the way I wanted to so I switched to move towards with a locked y value

    }
}
