using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public float speed = 100f;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        pos.y += speed* Time.deltaTime;

        Debug.Log(pos.y.ToString());

        //Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mouse.z = 0;
        //Vector2 point = mouse - transform.position;

        //transform.up = point;
    }
}
