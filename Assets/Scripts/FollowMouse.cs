using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowMouse : MonoBehaviour

    
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        //transform.position = Input.mousePosition;

        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        pos.y += speed * Time.deltaTime;
        Debug.Log(pos.y.ToString());
    }
}
