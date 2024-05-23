
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSoldier : MonoBehaviour
{

    public Transform LeftSpawn;
    public Transform RightSpawn;

    public GameObject Laserennemi;



    public float shotSpeed = 1f;
    public float laserRate = 2f;
    public float range = 1f;

    private bool canShoot = true;





    deplacements droite;

    player_detection detected;

    void Start()
    {
        droite = FindObjectOfType<deplacements>();

        detected = FindObjectOfType<player_detection>();
    }
    // Update is called once per frame
    void Update()
    {
        if (canShoot && detected.playerdetected)
        {

            //Left
            if (droite.toleft)
            {
                Debug.Log("left");
                Shoot(LeftSpawn, new Vector2(-1, 0));
            }

            //Right
            if (!droite.toleft)
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
        GameObject laser = Instantiate(Laserennemi, spawnPoint.position, Quaternion.identity);

        laser.GetComponent<Rigidbody2D>().velocity = shootDirection * shotSpeed;
        laser.GetComponent<Lasersoldier>().timeToDeath = range;



    }

    IEnumerator LaserRate()
    {
        yield return new WaitForSeconds(1f / laserRate);
        canShoot = true;
    }
}
