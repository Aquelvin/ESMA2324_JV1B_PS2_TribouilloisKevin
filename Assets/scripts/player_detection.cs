using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_detection : MonoBehaviour
{
    public BoxCollider2D bc2d;

    public bool playerdetected = false;
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
        if (other.CompareTag("Player"))
        {

            playerdetected = true;
        }

        

    }

    


    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerdetected = false;

        }

        
    }

}
