using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction_by_button_2 : MonoBehaviour
{
    // Start is called before the first frame update*
    button_by_laser_2 unlocked;
    void Start()
    {
        unlocked = FindObjectOfType<button_by_laser_2>();

    }

    // Update is called once per frame
    void Update()
    {
        if (unlocked.opened2)
        {
            Destroy(gameObject);
        }
    }
}
