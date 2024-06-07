using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateforme_up : MonoBehaviour
{

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
            if (to_up)
            {
                rgbd.velocity = new Vector2(rgbd.velocity.x, speedb);
            }
            else if (!to_up)
            {
                rgbd.velocity = new Vector2(rgbd.velocity.x, -speedb);
            }
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("uplimit2"))
        {
            to_up = false;

        }


        if (other.CompareTag("downlimit2"))
        {
            to_up = true;

        }
    }
}
