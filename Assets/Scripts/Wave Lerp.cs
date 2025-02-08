using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class WaveLerp : MonoBehaviour
{
    [Range(0, 1)]
    public float t; //Value to determine the position of the wave in proximity from Points A to B
    public Transform start; //Point A in the lerp movement scheme
    public Transform end; //Point B in the lerp movement scheme
    public bool wave = false; // Boolean to determine which direction the wave is going
    public AnimationCurve curve; //Animation curve to determine form of movement
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (/*(t <= 1) && */(wave == false)) // Boolean to determine which direction the wave is going
        {
            t += Time.deltaTime; // t increases in delta time, Wave moves from Point A to Point B
           if (t >= 1)
            {
                wave = true; // When the Wave reaches point B, flip the boolean so the code to run it in a different direction
            }
        }
        if (/*(t >= 1) && */(wave == true)) //Boolean to determine which direction the wave is going
        {
            t -= Time.deltaTime; // t decreases in delta time, Wave moves from Point B to Point A
            if (t <= 0)
            {
                wave = false; // When the Wave reaches point A, flip the boolean so the code to run it in a different direction
            }

        }
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t)); // Evaluate the lerp function using the animation curve and the t value
    }
}
