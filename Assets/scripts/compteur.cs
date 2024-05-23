using UnityEngine;
using UnityEngine.SceneManagement;

public class compteur : MonoBehaviour
{
    //public int requiredEliminations = 3; // Nombre d'ennemis à tuer pour permettre le changement de scène

    public int crystalcount = 0; // Compteur d'éliminations

    public bool cardone = false;

    public bool zone_1_unlock = false;

    // Fonction pour augmenter le compteur d'éliminations


    void Start()
    {

    }

    void Update()
    {
        if (crystalcount <= 0)
        {
            crystalcount = 0;
        }
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
        }

        if (other.CompareTag("porte_1") && crystalcount == 4 && cardone)
        {
            if (!zone_1_unlock)
            {
                Debug.Log("U");
                crystalcount -= 4;
                zone_1_unlock = true;
            }

        }
    }
}