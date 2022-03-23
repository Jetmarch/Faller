using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveOnAxis == Axis.X)
        {
            transform.Translate(Vector3.right * speed.value * Time.deltaTime, Space.World);
        }

        if(moveOnAxis == Axis.Y)
        {
            //transform.Translate(Vector3.up * speed.value * Time.deltaTime, Space.World);

            //rb.MovePosition(Vector3.up * speed.value * Time.deltaTime);
        }

        if(moveOnAxis == Axis.Z)
        {
            transform.Translate(Vector3.forward * speed.value * Time.deltaTime, Space.World);
        }
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(Vector3.up * speed.value );
    }
}
