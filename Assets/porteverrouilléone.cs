using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porteverrouilléone : MonoBehaviour
{

    compteur key;
    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<compteur>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && key.keytwo)
        {
            Destroy(gameObject);
        }
    }
}
