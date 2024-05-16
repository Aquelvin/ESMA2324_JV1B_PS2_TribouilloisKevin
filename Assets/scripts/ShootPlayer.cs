
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public Transform UpSpawn;
    public Transform LeftSpawn;
    public Transform RightSpawn;

    public GameObject Laser;

    public float shotSpeed = 1f;
    public float laserRate = 2f;
    public float range = 1.5f;

    private bool canShoot = true;


    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("up");
                Shoot(UpSpawn, new Vector2(0,1));
                
            }
            //Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("left");
                Shoot(LeftSpawn, new Vector2(-1, 0));
            }

            //Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("right");
                Shoot(RightSpawn, new Vector2(1, 0));
            }
        }
    }


    private void Shoot(Transform spawnPoint, Vector2 shootDirection)
    {
        canShoot = false;
        StartCoroutine(LaserRate());
        GameObject laser = Instantiate(Laser, spawnPoint.position, Quaternion.identity);
        laser.GetComponent<Rigidbody2D>().velocity = shootDirection*shotSpeed;
        laser.GetComponent<Laser>().timeToDeath = range;
    }

    IEnumerator LaserRate()
    {
        yield return new WaitForSeconds(1f/laserRate);
        canShoot = true;
    }
}
