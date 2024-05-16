using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftbutton = KeyCode.LeftArrow, rightbutton = KeyCode.RightArrow, jumpbutton = KeyCode.UpArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    [SerializeField]
    private BoxCollider2D bc2d;

    public Transform hitbox;

    public BoxCollider2D sol;


    public bool grounded = false;

    public bool toleft = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(jumpbutton) && grounded)
        {
            
            rgbd.velocity = new Vector2(rgbd.velocity.x, 8);
            grounded = false;
            //gameObject.GetComponent<Animator>().Play("JUMP");
            
        }
  
        if (Input.GetKey(leftbutton))
        {
            toleft = true;
            hitbox.localPosition = new Vector3(-0.973f, 0.005f, 0f);
            rgbd.AddForce(Vector2.left);
            if (rgbd.velocity.x < -6f)
            {
                rgbd.velocity = new Vector2(-6f, rgbd.velocity.y);
            }
            //if (grounded)
            //{
            //gameObject.GetComponent<Animator>().Play("marche");
            //}

            //else
            //{
            //gameObject.GetComponent<Animator>().Play("JUMP");
            //}
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(rightbutton))
        {
            toleft = false;
            hitbox.localPosition = new Vector3(0.99f, 0.005f, 0f);
            rgbd.AddForce(Vector2.right);

            if (rgbd.velocity.x > 6f)
            {
                rgbd.velocity = new Vector2(6f, rgbd.velocity.y);
            }

            //if (grounded)
            //{
                //gameObject.GetComponent<Animator>().Play("marche");
            //}

            //else
            //{
                //gameObject.GetComponent<Animator>().Play("JUMP");
            //}

            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        else
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);
            //if (grounded)
            //{
                //gameObject.GetComponent<Animator>().Play("AFK");
            //}

            //else
            //{
                //gameObject.GetComponent<Animator>().Play("JUMP");
            //}
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sol")
        {
            
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sol")
        {

            grounded = false;
        }
    }
}