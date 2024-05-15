using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, upkey = KeyCode.UpArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    [SerializeField]
    private BoxCollider2D bc2d;

    public Transform hitbox;

    public BoxCollider2D sol;


    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(upkey) && grounded)
        {
            rgbd.velocity = new Vector2(rgbd.velocity.x, 8);
            grounded = false;
            //gameObject.GetComponent<Animator>().Play("JUMP");
            
        }
  
        if (Input.GetKey(leftKey))
        {
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
        else if (Input.GetKey(rightKey))
        {
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

    private void OnTriggerEnter2D(Collider2D sol)
    {
        if (sol.CompareTag("sol"))
        {
            grounded = true;
        }
    }

}