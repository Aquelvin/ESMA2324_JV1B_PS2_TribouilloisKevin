using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_mannequin : MonoBehaviour
{
    //MANEQUIN
    public Collider2D col;
    public SpriteRenderer sprite;
    private bool can_die = true;
    private float respawn_time = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itbox_player") && can_die || other.CompareTag("laser") && can_die) { StartCoroutine(Death()); }
    }

    private IEnumerator Death()
    {
        col.enabled = false;
        sprite.enabled = false;
        can_die = false;
        yield return new WaitForSeconds(respawn_time);
        col.enabled = true;
        sprite.enabled = true;
        can_die = true;
    }
}