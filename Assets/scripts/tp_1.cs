
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_1 : MonoBehaviour
{
    [SerializeField]
    private KeyCode porte = KeyCode.E;
    public BoxCollider2D bc;

    compteur price;


    public bool enteredtp1 = false;

    // Start is called before the first frame update
    void Start()
    {
        price = FindObjectOfType<compteur>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (!price.zone_1_unlock)
        {
            Debug.Log("!price");
            if (   Input.GetKeyDown(porte) && other.CompareTag("Player") && price.crystalcount >= 0 && price.cardone)
                    {
                Debug.Log("passage1");
                        SceneManager.LoadScene(3);
                        

                        enteredtp1 = true; 

                    }
        }

        if (price.zone_1_unlock)
        {
            Debug.Log("price");
            if  (Input.GetKeyDown(porte))
                {
                Debug.Log("passage2");
                SceneManager.LoadScene(3);
                }
                
        }


    }
}