using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patern_soldier : MonoBehaviour
{
    public bool toleft = true;



    [SerializeField] private float speed;

    player_detection detected;

    public Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {
        detected = FindObjectOfType<player_detection>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detected.playerdetected)
        {
            rgbd.velocity = new Vector2(0, 0);
        }

        else
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
