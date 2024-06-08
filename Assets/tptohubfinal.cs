
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tptohubfinal : MonoBehaviour
{
    public BoxCollider2D bc;

    
    compteur treasure;

 

    // Start is called before the first frame update
    void Start()
    {
        
            treasure = FindObjectOfType<compteur>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            if (other.CompareTag("Player") && treasure.recoltone && treasure.recolttwo && treasure.recoltthree)
            {
                SceneManager.LoadScene(6);

                
  

            }

            else if  (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(2);
            }


    }
}