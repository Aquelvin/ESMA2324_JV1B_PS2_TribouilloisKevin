using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_by_laser : MonoBehaviour
{



    public BoxCollider2D bc2d;

    public bool lasertouch = false;


    public bool opened = false;

    public float nombrevie;
    public float vieperdue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (nombrevie <= 0)
        {
            nombrevie = 0;
            activated();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("laser"))
        {
            nombrevie -= vieperdue;

        }
    }


    void activated()
    {
        opened = true; ;
    }

}
