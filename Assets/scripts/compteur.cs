using UnityEngine;
using UnityEngine.SceneManagement;

public class compteur : MonoBehaviour
{
    //public int requiredEliminations = 3; // Nombre d'ennemis � tuer pour permettre le changement de sc�ne

    public int crystalcount = 0; // Compteur d'�liminations

    public bool cardone = false;

    // Fonction pour augmenter le compteur d'�liminations
    public void IncreaseEliminationCount()
    {
        

        // V�rifier si le nombre requis d'�liminations est atteint
        //if (eliminationCount >= requiredEliminations)

    }

    // Fonction pour changer de sc�ne
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
    }
}