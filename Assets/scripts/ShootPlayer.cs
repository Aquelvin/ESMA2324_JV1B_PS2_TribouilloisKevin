using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            rb.velocity = new Vector2(0, 1*movementSpeed);
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = new Vector2(-1*movementSpeed,0);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0,-1*movementSpeed);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(1*movementSpeed,0);
        }
    }
}
