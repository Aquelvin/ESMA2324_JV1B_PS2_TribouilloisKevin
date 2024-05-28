using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement de l'ennemi

    private Transform player; // Référence au joueur

    private bool canFollow = false;

    public Rigidbody2D rgbd;

    public GameObject enemy;

    [SerializeField] private float speed;

    MainMovement enemyScript;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Trouver le joueur
        enemyScript = FindObjectOfType<MainMovement>();
    }

    private void Update()
    {
        if (player != null && canFollow == true)
        {
            // Calculer la direction du mouvement vers le joueur
            Vector2 direction = player.position - transform.position;
            direction.Normalize();

            // Appliquer le mouvement
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
        else
        {
            if (enemyScript.toleft)
            {

                rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);
            }

            else if (!enemyScript.toleft)
            {

                rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canFollow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canFollow = false;
        }
    }
}