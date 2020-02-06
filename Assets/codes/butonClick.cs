using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonClick : MonoBehaviour
{
    public string tag,changeTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if(gameObject.tag == tag)
        {
            CountEnd.Instance.count++;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.tag = changeTag;
        }
        
        
    }
}
