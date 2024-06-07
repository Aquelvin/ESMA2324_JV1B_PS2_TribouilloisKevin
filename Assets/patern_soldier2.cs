using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern_soldier2 : MonoBehaviour
{
    public bool toleft = true;



    [SerializeField] private float speed;

    player_detection2 detected;

    public Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {
        detected = FindObjectOfType<player_detection2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detected.playerdetected)
        {
            rgbd.velocity = new Vector2(0, 0);
            if (GameObject.FindGameObjectWithTag("Player").transform.position.x < gameObject.transform.position.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                gameObject.GetComponent<Animator>().Play("soldier afk");


            }

            if (GameObject.FindGameObjectWithTag("Player").transform.position.x > gameObject.transform.position.x)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                gameObject.GetComponent<Animator>().Play("soldier afk");

            }

        }

        else
        {
            if (toleft)
            {

                rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                gameObject.GetComponent<Animator>().Play("soldier marche");

            }

            else if (!toleft)
            {

                rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                gameObject.GetComponent<Animator>().Play("soldier marche");

            }
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
