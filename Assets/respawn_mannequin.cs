using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_mannequin : MonoBehaviour
{

    [SerializeField]
    private KeyCode attack = KeyCode.Space;
    public BoxCollider2D bc2d;

    public bool aportee = false;

    public bool destroyed = false;

    public float respawntime = 1f;

    public bool shooted = false;
    public GameObject mannequin;

    
    // Start is called before the first frame update
    void Start()
    {
    

    }

    void Update()
    {
        if (destroyed)
        {
            //mannequin.SetActive(false);
            bc2d.enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(Respawn());
        }
        else
        {

            //mannequin.SetActive(true);
            bc2d.enabled = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (aportee)
        {
            if (Input.GetKeyDown(attack))
            {
                Debug.Log("destroyed");
                //Destroy(bc2d.gameObject);
                destroyed = true;
            }
        }
        else if (shooted)
        {
            Debug.Log("shooted");
            destroyed = true;

        }


    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawntime);
        //Destroy(gameObject);d
        destroyed = false;
        shooted = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            aportee = true;
        }
        if (other.CompareTag("laser"))
        {
            //Destroy(bc2d.gameObject);
            shooted = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player"))
        {

            aportee = false;
        }

        if (other.CompareTag("laser"))
        {
            //Destroy(bc2d.gameObject);
            shooted = false;
        }
    }

}