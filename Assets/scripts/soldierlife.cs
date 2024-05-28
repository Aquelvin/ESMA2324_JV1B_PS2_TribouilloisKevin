using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierlife : MonoBehaviour
{
    [SerializeField]
    private KeyCode attack = KeyCode.Space;


    public BoxCollider2D bc2d;

    public bool lasertouch = false;

    public bool aportee = false;


    public float nombrevie;
    public float vieperdue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (aportee)
        {
            if (Input.GetKeyDown(attack))
            {
                nombrevie -= vieperdue;
            }

        }



        if (nombrevie <= 0)
        {
            Death();
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
            nombrevie -= vieperdue;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            aportee = false;
        }

 
    }

    void Death()
    {
        Destroy(gameObject);
    }

}
