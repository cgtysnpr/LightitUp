using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChange : MonoBehaviour
{
    public float x, y;
    public string tag,changeTag;
    public bool relase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            relase = false;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            relase = true;
        }

    }
    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == tag)
        {


           
                if (relase == true)
                {
                    CountEnd.Instance.count++;
                    col.gameObject.transform.position = new Vector3(x, y, 1);
                    Debug.Log("deneme");
                    col.gameObject.tag = changeTag;
                }
               

            }
        



    }
}
