using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class WaveLerp : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public Transform start;
    public Transform end;
    public bool wave = false;
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(t.ToString()); 
        if (/*(t <= 1) && */(wave == false))
        {
            t += Time.deltaTime;
           if (t >= 1)
            {
                wave = true;
            }
        }
        if (/*(t >= 1) && */(wave == true))
        {
            t -= Time.deltaTime;
            if (t <= 0)
            {
                wave = false;
            }

        }
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
