using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement de l'ennemi

    private Transform boss; // Référence au joueur

    public GameObject mob;

    private void Start()
    {
        boss = mob.transform; // Trouver le joueur
    }

    private void Update()
    {
        if (boss != null)
        {
            // Calculer la direction du mouvement vers le joueur
            Vector2 direction = boss.position - transform.position;
            direction.Normalize();

            // Appliquer le mouvement
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}