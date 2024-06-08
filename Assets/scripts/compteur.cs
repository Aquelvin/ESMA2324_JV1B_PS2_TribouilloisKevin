using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class compteur : MonoBehaviour
{



        [SerializeField]
    private KeyCode money = KeyCode.Q, recupfull = KeyCode.E, hub = KeyCode.H;


    [SerializeField] private Text compteur_crystal;
    //public int requiredEliminations = 3; // Nombre d'ennemis � tuer pour permettre le changement de sc�ne

    public int crystalcount = 0; // Compteur d'�liminations

    public bool cardone= false;

    public bool cardone2 = false;

    public bool cardone3 = false;

    public bool zone_1_unlock = false;

    public bool zone_2_unlock = false;

    public bool zone_3_unlock = false;
    
    [SerializeField]  public Image cardA;

    [SerializeField] public Image cardB;

    [SerializeField] public Image cardC;

    [SerializeField] public Image cardD;

    [SerializeField] public Image tresorA;
    [SerializeField] public Image tresorB;
    [SerializeField] public Image tresorC;

    public bool keyone = false;

    public bool keytwo = false;

    public bool energy = false;

    public bool energy2 = false;


    public bool recoltone = false;

    public bool recolttwo = false;

    public bool recoltthree = false;

    // Fonction pour augmenter le compteur d'�liminations



    void Start()
    {
        
        cardA.enabled = false;
        cardB.enabled = false;
        cardC.enabled = false;
        cardD.enabled = false;

        tresorA.enabled = false;
        tresorB.enabled = false;
        tresorC.enabled = false;
    }

    void Update()
    {
        if (crystalcount <= 0)
        {
            crystalcount = 0;
        }
        compteur_crystal.text = "" + crystalcount;

        if (Input.GetKeyDown(money))
        {
            crystalcount+= 100;
        }

        else if (Input.GetKeyDown(recupfull))
        {
            cardone = true;
            cardA.enabled = true;

            cardone2 = true;
            cardB.enabled = true;

            cardone3 = true;
            cardC.enabled = true;

        }

        else if (Input.GetKeyDown(hub))
        {
            SceneManager.LoadScene(2);
            gameObject.transform.position = new Vector3(44f, -19f, 0f);
        }

        

    }
    // Fonction pour changer de sc�ne
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("crystal"))
        {
            crystalcount += 1;
            
        }
        if (other.CompareTag("card1"))
        {
            cardone = true;
            cardA.enabled = true;
        }

        if (other.CompareTag("card2"))
        {
            cardone2 = true;
            cardB.enabled = true;
        }

        if (other.CompareTag("card3"))
        {
            cardone3 = true;
            cardC.enabled = true;
        }
         if (other.CompareTag("tresorA"))
        {
            tresorA.enabled = true;
            recoltone = true;
        }
         if (other.CompareTag("tresorB"))
        {
            tresorB.enabled = true;
            recolttwo = true;
        }
         if (other.CompareTag("tresorC"))
        {
            tresorC.enabled = true;
            recoltthree = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    { 
        if (other.CompareTag("porte_1") && crystalcount >= 4 && cardone )
        {
            if (!zone_1_unlock)
            {
                Debug.Log("U");
                crystalcount -= 4;
                zone_1_unlock = true;
            }

        }

        if (other.CompareTag("porte_2") && crystalcount >= 10 && cardone2)
        {
            if (!zone_2_unlock)
            {
                Debug.Log("U");
                crystalcount -= 10;
                zone_2_unlock = true;
            }

        }

        if (other.CompareTag("porte_3") && crystalcount >= 15 && cardone3)
        {
            if (!zone_3_unlock)
            {
                Debug.Log("U");
                crystalcount -= 15;
                zone_3_unlock = true;
            }

        }

        if (other.CompareTag("keyone"))
        {
            keyone = true;
            
        }

        if (other.CompareTag("keytwo"))
        {
            keytwo = true;

        }

        if (other.CompareTag("energy"))
        {
            energy = true;

        }

        if (other.CompareTag("energy2"))
        {
            energy2 = true;

        }
    }

}