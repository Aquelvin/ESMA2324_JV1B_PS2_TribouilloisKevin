using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction_by_button : MonoBehaviour
{
    // Start is called before the first frame update*
    button_by_laser unlocked;
    void Start()
    {
        unlocked = FindObjectOfType<button_by_laser>();

    }

    // Update is called once per frame
    void Update()
    {
        if (unlocked.opened)
        {
            Destroy(gameObject);
        }
    }
}
