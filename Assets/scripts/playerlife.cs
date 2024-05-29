using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlife : MonoBehaviour
{
    public BoxCollider2D bc2d;
    public int lifecount = 5;
    public GameObject perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifecount <= 0)
                {
            Debug.Log("dead");
            death();
            
                }
    }

    public void PerdPv()
    {
        lifecount -= 1;


        // essaie de mettre le code de Mel ici, pour les frames d'invulnérabilité
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "soldier" || collision.gameObject.tag == "mob" || collision.gameObject.tag == "lasersoldier")
        {
            Debug.Log("touch)");
            PerdPv();


        }
        
        
    }

    public void death()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("lasersoldier"))
        {
            Debug.Log("touch)");
            PerdPv();


        }
        else if (other.CompareTag("heal"))
        {
            Debug.Log("heal");
            lifecount += 1;
            if (lifecount >= 5)
            {
                lifecount = 5;
            }
            


        }
    }

}
