using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountEnd : MonoBehaviour
{
    private static CountEnd _instance;

    public static CountEnd Instance { get { return _instance; } }

   
    public int count;
    public int end;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == end)
        {
            Light.Instance.move = true;
            ChangeScene.Instance.end = 4;
            Destroy(gameObject,1);
            
           
        }
    }

}
