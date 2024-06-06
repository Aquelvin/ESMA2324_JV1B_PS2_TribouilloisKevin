using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class compteur : MonoBehaviour
{

    [SerializeField] private Text compteur_crystal;
    //public int requiredEliminations = 3; // Nombre d'ennemis à tuer pour permettre le changement de scène

    public int crystalcount = 0; // Compteur d'éliminations

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

    public bool keyone = false;



    // Fonction pour augmenter le compteur d'éliminations

    [SerializeField]
    private KeyCode porte = KeyCode.E;

    void Start()
    {
        
        cardA.enabled = false;
        cardB.enabled = false;
        cardC.enabled = false;
        cardD.enabled = false;
    }

    void Update()
    {
        if (crystalcount <= 0)
        {
            crystalcount = 0;
        }
        compteur_crystal.text = "" + crystalcount;
    }
    // Fonction pour changer de scène
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("crystal"))
        {
            crystalcount += 1;
            
        }
        if (other.CompareTag("card"))
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

        if (other.CompareTag("porte_2") && crystalcount >= 10 && cardone)
        {
            if (!zone_2_unlock)
            {
                Debug.Log("U");
                crystalcount -= 10;
                zone_2_unlock = true;
            }

        }

        if (other.CompareTag("porte_3") && crystalcount >= 15 && cardone)
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
    }

}