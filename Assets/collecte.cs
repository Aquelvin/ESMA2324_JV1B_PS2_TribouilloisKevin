using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collecte : MonoBehaviour
{
    [SerializeField]
    public BoxCollider2D bcd;
    public bool detruit = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(bcd.gameObject);
            detruit = true;
        }
    }
}