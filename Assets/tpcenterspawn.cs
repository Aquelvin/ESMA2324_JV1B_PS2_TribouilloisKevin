using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpcenterspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = new Vector3(44f, -19f, 0f);
        }
    }
}
