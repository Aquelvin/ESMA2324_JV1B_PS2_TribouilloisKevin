using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_muraux : MonoBehaviour
{
    public bool leftwalled = false;

    public bool rightwalled = false;

    public Rigidbody2D rgbd;

    [SerializeField]
    private KeyCode jumpbutton = KeyCode.W;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpbutton) && leftwalled)
        {
            Debug.Log("jump");
            rgbd.velocity = new Vector2(8, 8);






        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
     

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
     

        if (other.CompareTag("leftwall"))
        {

            leftwalled = false;
        }

        if (other.CompareTag("rightwall"))
        {

            rightwalled = false;
        }
    }
}
