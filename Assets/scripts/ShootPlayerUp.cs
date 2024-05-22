using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayerUp : MonoBehaviour
{
    public Transform Upspawn;
    public GameObject LaserUp;

    public float shotSpeed = 1f;

    public float laserupRate = 2f;

    public bool canShoot = true;

    public float range = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            if (Input.GetKey(KeyCode.CapsLock))
            {
                shoot(Upspawn, new Vector2(0, 1));
                Debug.Log("laserup");
                
            }
        }
        
        
    }
    private void shoot(Transform spawnPoint, Vector2 shootDirection)
    {
        canShoot = false;
        StartCoroutine(LaserUpRate());

        GameObject laserup = Instantiate(LaserUp, spawnPoint.position, Quaternion.identity);
        laserup.GetComponent<Rigidbody2D>().velocity = shootDirection* shotSpeed;
        laserup.GetComponent<LaserUp>().timeToDeath = range;
    }

    IEnumerator LaserUpRate()
    {
        yield return new WaitForSeconds(1f/ laserupRate);
        canShoot = true;
    }
}
