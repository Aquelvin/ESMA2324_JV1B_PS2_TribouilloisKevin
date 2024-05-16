using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("up");
    }

    // Update is called once per frame
    void Update()
    {
        //up
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("up");
            //rb.velocity = new Vector2(0, 1*movementSpeed);
        }

        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            //rb.velocity = new Vector2(-1*movementSpeed,0);
        }

        //down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down");
            //rb.velocity = new Vector2(0,-1*movementSpeed);
        }

        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
            //rb.velocity = new Vector2(1*movementSpeed,0);
        }
    }
}
