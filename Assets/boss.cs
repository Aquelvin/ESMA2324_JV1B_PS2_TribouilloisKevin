using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class boss : MonoBehaviour
{
    public bool toleft = true;



    [SerializeField] private float speed;



    public Rigidbody2D rgbd;

    public bool test_button = false;


    [SerializeField] private int nmb;

    //ATTAQUE
    //[SerializeField] private Collider2D hitbox;
    [SerializeField] private GameObject hitbox;
    [SerializeField] private Transform hitboxtransform;
    private float atk_time = 0.2f;

    private float pausenumber = 6f;

    private float atk_cooldown =1f;
    //private float atk_cooldown;
    public bool can_atk = true;

    // Start is called before the first frame update
    void Start()
    {
        //hitbox.enabled = false;
        hitbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Nombregenerate());

        if (toleft)
        {

            left();
            hitboxtransform.localPosition = new Vector3(-3.969f, 2.9442f, 0f);
        }

        else if (!toleft)
        {

            right();
            hitboxtransform.localPosition = new Vector3(3.969f, 2.9442f, 0f);

        }
        
        
            if (GameObject.FindGameObjectWithTag("Player").transform.position.x < gameObject.transform.position.x)
            {
                hitboxtransform.localPosition = new Vector3(-3.969f, 2.9442f, 0f);
            }

            else if (GameObject.FindGameObjectWithTag("Player").transform.position.x > gameObject.transform.position.x)
            {
                hitboxtransform.localPosition = new Vector3(3.969f, 2.9442f, 0f);
            }
            attack();
        




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

    void left ()
    {
        rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
    }

    void right()
    {
        rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
    }

    void attack()
    {
        if (can_atk)
        {
           
            
            StartCoroutine(Atk());
        }
    }

    private IEnumerator Atk()
    {
        
        //hitbox.enabled = true;
        hitbox.SetActive(true);
        can_atk = false;
        yield return new WaitForSeconds(atk_time);
        //hitbox.enabled = false;
        hitbox.SetActive(false);
        yield return new WaitForSeconds(atk_cooldown);
        can_atk = true;
    }

    private IEnumerator Nombregenerate()
    {
        yield return new WaitForSeconds(pausenumber);
        
        Debug.Log("number");
        numbergenerator();

        yield return new WaitForSeconds(pausenumber);
    }
    void numbergenerator()
    {

        for (int j = 0; j < 4; j++)
        {
           nmb = UnityEngine.Random.Range(1,4); // returns random integers >= 10 and < 20
        }

    }

}

