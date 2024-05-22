using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
   

    public float timeToDeath = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Despawn());
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(timeToDeath);
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") && !other.CompareTag("laser") && !other.CompareTag("itbox_player") && !other.CompareTag("leftlimit") && !other.CompareTag("rightlimit") && !other.CompareTag("uplimit") && !other.CompareTag("downlimit") && !other.CompareTag("follow_goomba"))
        { 
            Destroy(gameObject);
        }
        
    }
}
