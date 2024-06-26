using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class parallax : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftbutton = KeyCode.LeftArrow, rightbutton = KeyCode.RightArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    deplacements dontmove;

    // Start is called before the first frame update
    void Start()
    {
        dontmove = FindObjectOfType<deplacements>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (dontmove.nospeed == true)
        {
            rgbd.velocity = new Vector2(0f, 0f);
        }


        else if (Input.GetKey(leftbutton))
        {

            rgbd.AddForce(Vector2.left);
            if (rgbd.velocity.x < -1.5f)
            {
                rgbd.velocity = new Vector2(-1.5f, rgbd.velocity.y);
            }

        }
        else if (Input.GetKey(rightbutton))
        {

            rgbd.AddForce(Vector2.right);

            if (rgbd.velocity.x > 1.5f)
            {
                rgbd.velocity = new Vector2(1.5f, rgbd.velocity.y);
            }

        }
        


        else
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);
        }


    }



}