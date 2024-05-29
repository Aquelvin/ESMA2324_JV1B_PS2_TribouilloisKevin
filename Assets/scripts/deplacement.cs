using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

    public bool leftwalled = false;

    public bool rightwalled = false;

    public bool nospeed = true;

    public bool canmove = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(jumpbutton) && grounded && canmove)
        {
            
            rgbd.velocity = new Vector2(rgbd.velocity.x, 9);
            grounded = false;
            //gameObject.GetComponent<Animator>().Play("JUMP");
            
        }


        else if (leftwalled && Input.GetKeyDown(jumpbutton))
        {
            canmove = false;
            rgbd.velocity = new Vector2(10, 8);
            hitbox.localPosition = new Vector3(0.4896f, 0.005f, 0f);
            Invoke("re_move", 0.7f);

        }

        else if (rightwalled && Input.GetKeyDown(jumpbutton))
        {
            canmove = false;
            rgbd.velocity = new Vector2(-10, 8);
            hitbox.localPosition = new Vector3(-0.4896f, 0.005f, 0f);
            Invoke("re_move", 0.7f);
        }


        else if (Input.GetKey(leftbutton) && canmove)
        {
            toleft = true;
            hitbox.localPosition = new Vector3(-0.4896f, 0.005f, 0f);
            rgbd.AddForce(Vector2.left);

            if (rgbd.velocity.x > -3f)
            {
                rgbd.velocity = new Vector2(-3f, rgbd.velocity.y);
            }

            if (rgbd.velocity.x < -7f)
            {
                rgbd.velocity = new Vector2(-7f, rgbd.velocity.y);
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
        else if (Input.GetKey(rightbutton) && canmove)
        {
            toleft = false;
            hitbox.localPosition = new Vector3(0.4896f, 0.005f, 0f);
            rgbd.AddForce(Vector2.right);

            if (rgbd.velocity.x < 3f)
            {
                rgbd.velocity = new Vector2(3f, rgbd.velocity.y);
            }

            if (rgbd.velocity.x > 7f)
            {
                rgbd.velocity = new Vector2(7f, rgbd.velocity.y);
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

        else if(grounded)
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
        if (rgbd.velocity == new Vector2(0f, rgbd.velocity.y))
        {
            nospeed = true;

        }

        else
        {
            nospeed = false;
        }
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("sol"))
        {

            grounded = true;
            canmove = true;
        }

        if (other.CompareTag("leftwall"))
        {

            leftwalled = true;
            
        }

        if (other.CompareTag("rightwall"))
        {

            rightwalled = true;
            
        }


    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("sol"))
        {

            grounded = true;
        }

        if (other.CompareTag("leftwall"))
        {

            leftwalled = true;
        }

        if (other.CompareTag("rightwall"))
        {

            rightwalled = true;
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("sol"))
        {

            grounded = false;
        }

        if (other.CompareTag("leftwall"))
        {

            leftwalled = false;
        }

        if (other.CompareTag("rightwall"))
        {

            rightwalled = false;
        }
    }

    public void re_move()
    {
        canmove = true;
    }

   
}