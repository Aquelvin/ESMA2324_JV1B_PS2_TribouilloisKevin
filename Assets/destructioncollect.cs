using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructioncollect : MonoBehaviour
{
    public BoxCollider2D bc2D;

    public SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            image.enabled = false;
        }
    
    }
}
