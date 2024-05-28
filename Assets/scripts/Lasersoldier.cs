using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasersoldier : MonoBehaviour
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
        if (!other.CompareTag("Player") && !other.CompareTag("laser")&& !other.CompareTag("leftlimit") && !other.CompareTag("lasersoldier") && !other.CompareTag("rightlimit") && !other.CompareTag("uplimit") && !other.CompareTag("downlimit") && !other.CompareTag("follow_goomba") && !other.CompareTag("not_impact_by_laser") && !other.CompareTag("soldier") && !other.CompareTag("itbox_player"))
        {
            Destroy(gameObject);
        }

    }
}
