using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderFlip : MonoBehaviour
{
public GameObject enemy;
public BoxCollider2D coll;
public Player_Script player;

public bool playerEnterExit;

public Vector3 StartingRotation; 
public Vector2 startPos;

public float timer = 3;
void Start()
    {
    enemy.transform.position = startPos; 
    transform.rotation = Quaternion.Euler(StartingRotation);
    }
void Update()
    {
    if(playerEnterExit == true)
        {
        timer -= Time.deltaTime;
        }
    if(playerEnterExit == false)
        {
        timer = 2;
        }
//////Timer at 0//////
        if(timer <= 0)
            {
            player.reset();
            reset();
            }
}
void OnTriggerEnter2D(Collider2D enter)
    {
    if(enter.gameObject.tag == "Player")
        {
        playerEnterExit = true;
        }
    }
void OnTriggerExit2D(Collider2D exit)
    {
    if(exit.gameObject.tag == "Player")
        {
        playerEnterExit = false;
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
