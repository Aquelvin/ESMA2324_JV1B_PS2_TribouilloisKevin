using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectheal : MonoBehaviour
{

    public BoxCollider2D bcd;
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

            Destroy(bcd.gameObject);
            
        }
    }
}
