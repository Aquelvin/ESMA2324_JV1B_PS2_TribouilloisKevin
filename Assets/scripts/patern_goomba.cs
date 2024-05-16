using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern_goomba : MonoBehaviour
{
    public bool toleft = true;

    

    [SerializeField] private float speed;



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

                rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);

        }

        else if (!toleft)
        {
            
                rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
           
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("leftlimit"))
        {
            toleft = false;
           
        }

        if (other.CompareTag("rightlimit"))
        {
            toleft = true;
          
        }


    }
}
