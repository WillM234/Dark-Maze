using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderFlip : MonoBehaviour
{
public GameObject enemy;
public BoxCollider2D coll;
public Player_Script player;


public Vector3 StartingRotation; 
//private Vector3 MovingRight = new Vector3(0f,0f,180f);
//private Vector3 MovingLeft = new Vector3(0f,0f,0f);
//private Vector3 MovingUp = new Vector3(0f,0f, -90f);
//private Vector3 MovingDown = new Vector3(0f,0f, 90f);


public Vector2 startPos;

private float timer = 3;
void Start()
    {
    enemy.transform.position = startPos; 
    transform.rotation = Quaternion.Euler(StartingRotation);
    }
void Update()
    {
//////Timer at 0//////
        if(timer <= 0)
            {
            player.reset();
            reset();
            timer = 3;
            }
}
void OnTriggerEnter(Collider other)
    {
    /*if(other.gameObject.tag == "Player")
        {
        timer = 3;
        }*/
    }
void OnTriggerStay(Collider Other)
    {
    if(Other.gameObject.tag == "Player")
        {
        timer -= Time.deltaTime; 
        }
    }
void OnTriggerExit(Collider exit)
    {
    if(exit.gameObject.tag == "Player")
        {
        timer = 3;
        }
    }
public void XrotationR()
    {
    transform.rotation = Quaternion.Euler(0,0,180);
    }
public void XrotationL()
    {
    transform.rotation = Quaternion.Euler(0,0,0);
    }
public void YrotationU()
    {
   transform.rotation = Quaternion.Euler(0,0,-90);
    }
public void YrotationD()
    {
    transform.rotation = Quaternion.Euler(0,0,90);
    }
public void reset()
    {
    enemy.transform.position = startPos;
    transform.rotation = Quaternion.Euler(StartingRotation);
    }
}
