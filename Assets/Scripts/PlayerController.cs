using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private SOFloat moveSpeed;


    private Vector3 screenPoint;
    private Vector3 offset;
    private Tween tween;

    private Rigidbody rb;

    private void Awake()
    {
        DOTween.Init();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint);
            // transform.position = new Vector3(cursorPosition.x, cursorPosition.y, 0f);

            //transform.DOMove(new Vector3(cursorPosition.x, cursorPosition.y, 0f), moveSpeed);

            //transform.DOMove(cursorPosition, moveSpeed.value);

           tween = rb.DOMove(cursorPosition, moveSpeed.value);

         //   rb.MovePosition(cursorPosition);
        }

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.angularDrag = 0f;

            screenPoint = Camera.main.WorldToScreenPoint(transform.position);

            offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(
                Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Tween killed");
        tween.Kill();

        Debug.Log($"{collision.relativeVelocity.magnitude}");

        rb.velocity = Vector3.zero;

        if(collision.relativeVelocity.magnitude > 2)
        {
            //Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision stay");
    }

    private void OnMouseDrag()
    {
       /* Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;*/
    }

    private void OnMouseDown()
    {
        /*screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));*/
    }
}
