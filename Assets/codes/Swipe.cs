﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 startTouchPosition, endTouchPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began){
            startTouchPosition = Input.GetTouch(0).position;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if((endTouchPosition.x<startTouchPosition.x)&& transform.position.x > -1.75f)
            {
                transform.position = new Vector2(transform.position.x - 1.75f, transform.position.y);
            }
        }
    }
}
