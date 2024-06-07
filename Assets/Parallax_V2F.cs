using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_V2F : MonoBehaviour
{
    private Transform target;
    public float smoothing;
    public float level; //niveau d'arri�re plan
    private float initialPositionx;
    private float initialPositiony;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        initialPositionx = gameObject.transform.position.x; //r�cup�re la position initiale en x
        initialPositiony = gameObject.transform.position.y; //r�cup�re la position initiale en y
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x + (initialPositionx * level), initialPositiony * level, 5) / level; //calcule la position vis�e
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing); //effectue le mouvement
    }
}