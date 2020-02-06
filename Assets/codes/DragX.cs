using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragX : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 screenPoint;
    public float y;
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
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "drag")
        {

            Light.Instance.move = true;
            ChangeScene.Instance.end = 4;
            Destroy(gameObject);
            Destroy(col.gameObject);

        }
    }
}
