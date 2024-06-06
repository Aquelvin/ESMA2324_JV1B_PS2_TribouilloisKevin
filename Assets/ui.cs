using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class life_ui : MonoBehaviour
{

    public BoxCollider2D bc;

    public Rigidbody2D rgbd;

    public float speed;
    private float horizontal;
    private float vertical;

    public RectTransform health_bar;
    public float respiration;
    public float res_perdue;
    public float res_regen;

    public bool aportee = false;



    [SerializeField]
    private KeyCode breathing;

    public Canvas ui;

    playerlife counter;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter = FindObjectOfType<playerlife>();
    }

    private void FixedUpdate()
    {
        Res_perd();
        //if (aportee && Input.GetKey(breathing))
        //{
          //  Res_gagne();
       // }
        //horizontal = Input.GetAxisRaw("Horizontal");
        //vertical = Input.GetAxisRaw("Vertical");

        //rgbd.velocity = new Vector2(horizontal, vertical).normalized * speed;

        if (counter.lifecount <= 0)
        {
            ui.enabled = false;
            Death();
        }
    }

    private void Res_perd()
    {
        //respiration -= res_perdue;
        health_bar.transform.localScale = new Vector3((counter.lifecount/ 5f)*3, 3f,1f);
    }

    //void Res_gagne()
    //{
       // respiration += res_regen;
       // if (respiration > 100)
       // {
        //    respiration = 100;
        //}
       // health_bar.transform.localScale = new Vector3(respiration / 100f, 1f, 1f);
    //}

    void Death()
    {

        SceneManager.LoadScene(13);

        Destroy(gameObject);
    }

    //private void OnTriggerEnter2D(Collider2D other)
   // {
       // if (other.CompareTag("hitboxrespi"))
       // {

        //    aportee = true;
       // }
    //}
   // private void OnTriggerExit2D(Collider2D other)
   // {
       // if (other.CompareTag("hitboxrespi"))
       // {

          //  aportee = false;
        //}
    //}
}