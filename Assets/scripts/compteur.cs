using UnityEngine;
using UnityEngine.SceneManagement;

public class compteur : MonoBehaviour
{
    //public int requiredEliminations = 3; // Nombre d'ennemis � tuer pour permettre le changement de sc�ne

    public int crystalcount = 0; // Compteur d'�liminations

    public bool cardone = false;

    public bool zone_1_unlock = false;

    // Fonction pour augmenter le compteur d'�liminations

    [SerializeField]
    private KeyCode porte = KeyCode.E;

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
    private void OnTriggerStay2D(Collider2D other)
    { 
        if (other.CompareTag("porte_1") && crystalcount >= 4 && cardone && Input.GetKeyDown(porte))
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