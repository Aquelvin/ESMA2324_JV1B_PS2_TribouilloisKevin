using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class deplacements : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftbutton = KeyCode.LeftArrow, rightbutton = KeyCode.RightArrow, jumpbutton = KeyCode.UpArrow, attack = KeyCode.Space;

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

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

     
        if (Input.GetKeyDown(jumpbutton) && grounded && canmove)
        {
            
            rgbd.velocity = new Vector2(rgbd.velocity.x, 10);
            
            gameObject.GetComponent<Animator>().Play("jump");
            grounded = false;

            


            //if (toleft)
            //{
            //gameObject.GetComponent<SpriteRenderer>().flipX = true;
            //gameObject.GetComponent<Animator>().Play("jump");
            //}
            //else
            //{
            //  gameObject.GetComponent<SpriteRenderer>().flipX = false;
            // gameObject.GetComponent<Animator>().Play("jump");
            //}


        }



        else if (leftwalled && Input.GetKeyDown(jumpbutton))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.GetComponent<Animator>().Play("jump");
            canmove = false;
            rgbd.velocity = new Vector2(10, 8);
            hitbox.localPosition = new Vector3(1.0584f, -0.0259f, 0f);
            Invoke("re_move", 0.7f);

        }

        else if (rightwalled && Input.GetKeyDown(jumpbutton))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.GetComponent<Animator>().Play("jump");
            canmove = false;
            rgbd.velocity = new Vector2(-10, 8);
            hitbox.localPosition = new Vector3(-1.0584f, -0.0259f, 0f);
            Invoke("re_move", 0.7f);
        }

    
        else if (Input.GetKey(leftbutton) && canmove)
        {
            toleft = true;
            hitbox.localPosition = new Vector3(-5.919217f, -2f, 0f);
            rgbd.AddForce(Vector2.left);

            if (rgbd.velocity.x > -5f)
            {
                rgbd.velocity = new Vector2(-5f, rgbd.velocity.y);
            }

            if (rgbd.velocity.x < -10f)
            {
                rgbd.velocity = new Vector2(-10f, rgbd.velocity.y);
            }

            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            if (grounded)
            {
                gameObject.GetComponent<Animator>().Play("course");
            }

            else
            {
             gameObject.GetComponent<SpriteRenderer>().flipX = true;
             gameObject.GetComponent<Animator>().Play("jump");
            }

        }
        else if (Input.GetKey(rightbutton) && canmove)
        {
            toleft = false;
            hitbox.localPosition = new Vector3(5.919217f, -2f, 0f);
            rgbd.AddForce(Vector2.right);

            if (rgbd.velocity.x < 5f)
            {
                rgbd.velocity = new Vector2(5F, rgbd.velocity.y);
            }

            if (rgbd.velocity.x > 10f)
            {
                rgbd.velocity = new Vector2(10f, rgbd.velocity.y);
            }

            gameObject.GetComponent<SpriteRenderer>().flipX = false;

            if (grounded)
            {
                gameObject.GetComponent<Animator>().Play("course");
            }

            else
            {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.GetComponent<Animator>().Play("jump");
            }


        }

        else if (grounded)
        {
            rgbd.velocity = new Vector2(0f, rgbd.velocity.y);




            gameObject.GetComponent<Animator>().Play("afk");



            //else if (grounded && Input.GetKeyDown(jumpbutton))
            //{
            //   gameObject.GetComponent<Animator>().Play("jump");
            //}

        }

        if (Input.GetKeyDown (attack))
        {
            Debug.Log("boom");
            gameObject.GetComponent<Animator>().Play("coupdepied");
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