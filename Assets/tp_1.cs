
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_1 : MonoBehaviour
{
    public BoxCollider2D bc;

    compteur price;

    // Start is called before the first frame update
    void Start()
    {
        price = FindObjectOfType<compteur>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && price.crystalcount >= 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}