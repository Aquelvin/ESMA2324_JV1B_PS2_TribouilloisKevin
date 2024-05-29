using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIAMESTDEVENUFOU : MonoBehaviour
{
    
    //ATTAQUE
    [SerializeField] private Collider2D hitbox;
    private float atk_time = 0.1f;
    //private float atk_cooldown;
    public bool can_atk = true;

    
    private void Start()
    {
        hitbox.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && can_atk)
        {
            Atk();
        }
    }
    
    private IEnumerator Atk()
    {
        hitbox.enabled = true;
        can_atk = false;
        yield return new WaitForSeconds(atk_time);
        hitbox.enabled = false;
        //  yield return new WaitForSeconds(atk_cooldown);
        can_atk = true;
    }

    /**
    //MANEQUIN
    private Collider2D col;
    private SpriteRenderer sprite;
    private bool can_die = true;
    private float respawn_time = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itbox") && can_die || other.CompareTag("Tir") && can_die) { StartCoroutine(Death()); }
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
    */
}
