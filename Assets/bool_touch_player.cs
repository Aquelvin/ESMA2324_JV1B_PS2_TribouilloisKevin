using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bool_touch_player : MonoBehaviour
{
    public bool nexttoplayer = false;

    public BoxCollider2D bc2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            nexttoplayer = true;

        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            nexttoplayer = false;

        }

    }
}
