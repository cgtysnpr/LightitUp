using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBall : MonoBehaviour
{
    public Vector2 startPos, endPos, direction;
    Rigidbody2D myRigidbody2D;
    public float shootPower = 10f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
    }
    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            direction = startPos - endPos;
          
            myRigidbody2D.isKinematic = false;
            myRigidbody2D.AddForce(direction * shootPower);
            

        
            
            
           
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Finish")
        {
            
            Light.Instance.move = true;
            ChangeScene.Instance.end = 4;
            Destroy(gameObject);
            Destroy(col.gameObject);

        }
    }
    


}
