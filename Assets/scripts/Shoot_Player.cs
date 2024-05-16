using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Player : MonoBehaviour
{
    //[SerializeField]
    //private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, upkey = KeyCode.UpArrow;
    public bool up = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.LogAssertion("up");

            up = true;
            //rb.velocity = new Vector2(0, 1*movementSpeed);
        }

        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.LogAssertion("left");
            //rb.velocity = new Vector2(-1*movementSpeed,0);
        }

        //down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.LogAssertion("down");
            //rb.velocity = new Vector2(0,-1*movementSpeed);
        }

        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.LogAssertion("right");
            //rb.velocity = new Vector2(1*movementSpeed,0);
        }
    }
}
