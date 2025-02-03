using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
    public float speed = 1f;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; 
        mousePos.y = -2.6f;
        mousePos.x =pos;
        //transform.position = Input.mousePosition;


        //Vector2 pos = transform.position;
        pos = transform.position.x; 
        //pos.x += mousePos.x;
        //pos.y = -2.6f;
        //Debug.Log(pos.x.ToString());
    }
}
