using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        }
    }


}
