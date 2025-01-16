using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockHand : MonoBehaviour
{
    [Range(0,1)]
    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z -= speed;
        transform.eulerAngles = rot;
    }
}
