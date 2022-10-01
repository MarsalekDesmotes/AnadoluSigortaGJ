using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public TimeManager time;
    public  Animator Anim,YanmaAnim;
    public GameObject Meteor;
    public GameObject CarMotor;
    public HingeJoint2D hinge;
    public bool ulasti;
    public AudioSource yanmaSesi;
    public int sayac = 0;
    public float sayacZaman;
    bool isBurning;
    public Animator Teker1, Teker2;
    
    Scene scene;
    
    Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurning)
        {
            Debug.Log("yandý");
            rb.velocity = Vector2.zero;
            sayacZaman +=Time.deltaTime;
        }
        
        if (ulasti == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (sayacZaman > 2)
        {

            SceneManager.LoadScene(scene.name);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Debug.Log("Calisti");
            Anim.SetTrigger("Meteor");
            Meteor.GetComponent<Rigidbody2D>().velocity = new Vector3(0,20000*Time.deltaTime,0);
            //Meteor.gameObject.GetComponent<BoxCollider2D>().enabled = false; çalýþmadý
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            time.slowMotionEffectCall();
            //collision.transform.GetChild(0).GetComponent<HingeJoint2D>().enabled = false;
            //hinge.breakTorque = 0;
            var motorDeger = 0f;
            ulasti = true;
            
            
            
           
        }



       


        
        





    }




    private void OnTriggerEnter2D(Collider2D collision)
    {


        
        if (collision.gameObject.tag == "Ates")
        {
            isBurning = true;
            Teker1.enabled = false;
            Teker2.enabled = false;
          
            Debug.Log("ana");
            YanmaAnim.SetTrigger("Yan");
            if (sayac < 1) {
                
                yanmaSesi.Play();
                sayac++;
                
            }


           
            




        }
    }

}
