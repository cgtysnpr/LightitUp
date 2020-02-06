using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public int deneme = 0;
    private static ChangeScene _instance;
    public string scene;
    public static ChangeScene Instance { get { return _instance; } }
    public float end = -1f;
    
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
        InvokeRepeating("AddValue", 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Light.Instance.move==true)
        {
         
            
                
            
            
                
            if (end == 0)
            {
                SceneManager.LoadScene(scene);
            }
               
            
        }
    }

    void AddValue()
    {
        end--;
    }
}
