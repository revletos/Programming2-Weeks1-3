using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    [Range (0,1)]
    public float t;
    public Transform start;
    public Transform end;
    public bool wave= false;

    public AnimationCurve curve;
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
       transform.position = Vector2.Lerp(start.position, end.position,curve.Evaluate(t));
    }
}
