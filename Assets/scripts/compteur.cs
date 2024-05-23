using UnityEngine;
using UnityEngine.SceneManagement;

public class compteur : MonoBehaviour
{
    //public int requiredEliminations = 3; // Nombre d'ennemis à tuer pour permettre le changement de scène

    public int crystalcount = 0; // Compteur d'éliminations

    public bool cardone = false;

    // Fonction pour augmenter le compteur d'éliminations
    public void IncreaseEliminationCount()
    {
        

        // Vérifier si le nombre requis d'éliminations est atteint
        //if (eliminationCount >= requiredEliminations)

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
    }
}