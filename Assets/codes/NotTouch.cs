﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotTouch : MonoBehaviour
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
    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == tag)
        {

            

            CountEnd.Instance.count++;
            
            col.gameObject.tag = changeTag;
        }


    }
}
