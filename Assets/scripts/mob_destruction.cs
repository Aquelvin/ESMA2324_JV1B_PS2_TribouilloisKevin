using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob_destruction : MonoBehaviour
{
    [SerializeField]
    private KeyCode attack = KeyCode.Space;


    public BoxCollider2D bc2d;



    public bool aportee = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    /**
    // Update is called once per frame
    void Update()
    {
        if (aportee)
        {
            if (Input.GetKeyDown(attack))
            {
                Destroy(bc2d.gameObject);
            }


        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            aportee = true;
        }
        if (other.CompareTag("laser"))
        {
            Destroy(bc2d.gameObject);

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            aportee = false;
        }


    }
    */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            Destroy(bc2d.gameObject);
        }
        if (other.CompareTag("laser"))
        {
            Destroy(bc2d.gameObject);

        }
    }
   // private void OnTriggerExit2D(Collider2D other)
   // {
     //   if (other.CompareTag("itbox_player"))
       // {

       //     aportee = false;
       // }


    //}

}
