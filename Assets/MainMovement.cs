using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{
    public bool toleft = true;
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
        if (other.gameObject.CompareTag("leftlimit"))
        {
            toleft = false;
        }
        if (other.gameObject.CompareTag("rightlimit"))
        {
            toleft = true;
        }
    }
}
