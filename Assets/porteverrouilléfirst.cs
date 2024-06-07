using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porteverrouilléfirst : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player") && key.keyone)
        {
            Destroy(gameObject);
        }
    }
}
