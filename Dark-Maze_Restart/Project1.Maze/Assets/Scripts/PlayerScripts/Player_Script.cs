using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
private float speed = .005f;
private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed);
   /*rb2d.AddForce(-transform.right * speed * Time.deltaTime)*/; 
    }
if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
    /*rb2d.AddForce(transform.right * speed * Time.deltaTime)*/;
    }
if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
    /*rb2d.AddForce(transform.forward*speed * Time.deltaTime)*/;
    }
if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed);
    /*rb2d.AddForce(-transform.forward*speed * Time.deltaTime)*/;
    }
    }
}
