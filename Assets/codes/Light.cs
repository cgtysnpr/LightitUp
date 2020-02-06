using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private static Light _instance;

    public static Light Instance { get { return _instance; } }




    public float speed;
    public bool move;
    // Start is called before the first frame update

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
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
        if (move == true)
        {
            transform.Translate(0, 0, -2 * Time.deltaTime * speed);
            
        }
        
    }
    
}
