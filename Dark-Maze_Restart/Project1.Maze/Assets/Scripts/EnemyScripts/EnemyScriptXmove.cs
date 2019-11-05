using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptXmove : MonoBehaviour
{
public float xleftMax;
public float xrightMax;
public float speed;
private float pauseSpeed = 0f;
private float OSpeed;
public bool canMove;
public bool movingR;
public Player_Script player;
public EnemyColliderFlip flip;//remember to set this in editor
public PauseMenu pause;
private Vector2 MVect;
    // Start is called before the first frame update
    void Start()
    {
MVect.x = -1f;
canMove = true;
OSpeed = -speed;
    }

    // Update is called once per frame
    void Update()
{
//automates movement of enemy. Have to set min/max in editor 
Vector2 newPos = new Vector2(transform.position.x + MVect.x * speed, transform.position.y + MVect.y * speed); 
if(pause.pauseOnOff == true)//movement stopped when pasued
    {
    canMove = false;
    }
if(pause.pauseOnOff == false)//movement starts when unpaused
    {
    canMove = true;
    }
if(canMove == true)//allows movement when not paused
    {
    //constrains enemy movemnet. Has to be set in editor
   MVect.x = -1f;
    if(newPos.x <= xleftMax)
        {
        speed = -speed;
        movingR = false;
        }
    if(newPos.x >= xrightMax)
        {
        speed = -speed; 
        movingR = true; 
        }
    if(movingR == true)
        {
        flip.XrotationL();
        }
    if(movingR == false)
        {
        flip.XrotationR();
        }
    }
if(canMove == false)
    {
    MVect.x = 0f;
    }
if(player.Win == true)//movement stopped when win
    {
    canMove = false;
    }
if(player.Lose == true)//movement stopped when lose
    {
    canMove = false;
    }

transform.position = newPos;
}
}
