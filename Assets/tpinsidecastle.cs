using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpinsidecastle : MonoBehaviour
{
    compteur power;
    // Start is called before the first frame update
    void Start()
    {
        power = FindObjectOfType<compteur>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && power.energy2)
        {
            collision.gameObject.transform.position = new Vector3(150f, 100f, 0f);
        }
    }
}
