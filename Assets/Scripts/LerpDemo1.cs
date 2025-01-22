using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LerpDemo1 : MonoBehaviour
{
    [Range (0,1)]
    public float t1;
    public Transform start1;
    public Transform middle1;
    public Transform end1;
    public float timer;
    public float order;

    public AnimationCurve curve1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = new Vector2(Mathf.Lerp(-4, 5, t), 0);
        //transform.position = pos;

        //Alt:
        timer += 0.001f;
        t1 = timer;
        order = 1;

        if (order == 1)
        {
            transform.position = Vector2.Lerp(start1.position, middle1.position, curve1.Evaluate(t1));
            if (t1 >= 1)
            {
                timer = 0;
                order = 2;
            }
            
        }
        if (order == 2)
        { 
            transform.position = Vector2.Lerp(middle1.position, end1.position, curve1.Evaluate(t1));
            if (t1 >= 1)
            {
                timer = 0;
                order = 3;
            }
        }
        if (order == 3) 
        { 
            transform.position = Vector2.Lerp(end1.position, start1.position, curve1.Evaluate(t1));
            if (t1 >= 1)
            {
                timer = 0;
                order = 1;
            }
        }
    
        //transform.position = Vector2.Lerp(start1.position, end1.position,curve1.Evaluate(t1));
        
    }
}
