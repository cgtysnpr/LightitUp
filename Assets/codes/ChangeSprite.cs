using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite sprite;
    public string tag;
    public bool enter;
    public string changeTag;
    bool hasEntered = true;
    
    
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
        
            if (col.gameObject.tag == tag&&enter==false&&hasEntered==true)
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;

                CountEnd.Instance.count++;
                hasEntered = false;
                gameObject.tag = changeTag;
        }
        
       
    }
    void OnTriggerEnter2D(Collider2D col)
    {
      
            if (col.gameObject.tag == tag&&enter==true&&hasEntered==true)
            {
                CountEnd.Instance.count++;
                 
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
                hasEntered = false;
                gameObject.tag = changeTag;

            }

        
        
    }
}
