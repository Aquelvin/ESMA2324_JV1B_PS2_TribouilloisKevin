using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern_volant : MonoBehaviour
{
    public bool toleft = true;

    public bool to_up = true;

    [SerializeField] private float speed;

    [SerializeField] private float speedb;

    public Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (toleft)
        {
            if (to_up)
            {
                rgbd.velocity = new Vector2(-speed, speedb);
            }
            else if (!to_up)
            {
                rgbd.velocity = new Vector2(-speed, -speedb);
            }
        }

        else if (!toleft)
        {
            if (to_up)
            {
                rgbd.velocity = new Vector2(speed, speedb);
            }
            else if (!to_up)
            {
                rgbd.velocity = new Vector2(speed, -speedb);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("leftlimit"))
        {
            toleft = false;
            if (to_up)
            {
                to_up = false;
            }
            else if (!to_up)
            {
                to_up = true;
            }
        }

        if (other.CompareTag("rightlimit"))
        {
            toleft = true;
            if (to_up)
            {
                to_up = false;
            }
            else if (!to_up)
            {
                to_up = true;
            }
        }


        if (other.CompareTag("uplimit"))
        {
            to_up = false;

        }


        if (other.CompareTag("downlimit"))
        {
            to_up = true;

        }
    }
}
