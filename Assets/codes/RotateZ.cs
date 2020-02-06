using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{
    Vector3 oldMousePos;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        oldMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 diff = Input.mousePosition - oldMousePos;
        oldMousePos = Input.mousePosition;
        float angle = diff.x * rotationSpeed;
        transform.Rotate(Vector3.forward, angle);
    }
}
