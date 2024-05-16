using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Player : MonoBehaviour
{
    public Transform UpSpawn;
    //public Transform DownSpawn;
    public Transform LeftSpawn;
    public Transform RightSpawn;
    public GameObject laser;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Shoot(UpSpawn);
            Debug.LogAssertion("up");

            //rb.velocity = new Vector2(0, 1*movementSpeed);
        }

        //left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Shoot(LeftSpawn);
            Debug.LogAssertion("left");
            //rb.velocity = new Vector2(-1*movementSpeed,0);
        }

        //down
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
           // Debug.LogAssertion("down");
            //rb.velocity = new Vector2(0,-1*movementSpeed);
        //}

        //right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Shoot(RightSpawn);
            Debug.LogAssertion("right");
            //rb.velocity = new Vector2(1*movementSpeed,0);
        }
    }

    private void Shoot(Transform spawnPoint, Vector2 shootDirection)
    {
        GameObject laser = Instantiate(laser, spawnPoint.position, Quaternion.identity);
        laser.GetComponent<Rigidbody2D>().velocity = shootDirection;
        
    }
}
