using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RScene : MonoBehaviour
{
    public string restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CountEnd.Instance.count == CountEnd.Instance.end)
        {
            Destroy(gameObject);
        }
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene(restart);

    }

}
