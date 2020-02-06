using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUpTouch : MonoBehaviour
{
    private static MouseUpTouch _instance;

    public static MouseUpTouch Instance { get { return _instance; } }
    public bool relase;

    // Start is called before the first frame update
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {

        }
        else
        {
            _instance = this;
        }
    }
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
}
