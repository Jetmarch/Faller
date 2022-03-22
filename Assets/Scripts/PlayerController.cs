using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;
    }

    private void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
}
