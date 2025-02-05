using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        Debug.Log(pos.x.ToString());

        if ((pos.x > 13) || (pos.x < -15))
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
