using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisMove : MonoBehaviour
{
    public enum Axis
    {
        X,
        Y,
        Z
    }

    public Axis moveOnAxis;
    public SOFloat speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveOnAxis == Axis.X)
        {
            transform.Translate(new Vector3(speed.value * Time.deltaTime, 0f, 0f));
        }

        if(moveOnAxis == Axis.Y)
        {
            transform.Translate(new Vector3(0f, speed.value * Time.deltaTime, 0f));
        }

        if(moveOnAxis == Axis.Z)
        {
            transform.Translate(new Vector3(0f, 0f, speed.value * Time.deltaTime));
        }
    }
}
