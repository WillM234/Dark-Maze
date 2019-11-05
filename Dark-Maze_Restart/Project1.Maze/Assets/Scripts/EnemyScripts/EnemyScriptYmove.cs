using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptYmove : MonoBehaviour
{
public float upMax;
public float downMax;
public float speed;
private float pauseSpeed = 0f;
private float actualSpeed;
public bool canMove;
public bool movingUp;
public Player_Script player;
public EnemyColliderFlip flip;
public PauseMenu pause;

private Vector2 MVect;
    // Start is called before the first frame update
    void Start()
    {
MVect.y = -1f; 
canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
Vector2 newPos = new Vector2(transform.position.x + MVect.x * actualSpeed, transform.position.y + MVect.y * speed); 
    
if(canMove == true)
    {
    MVect.y = -1f;
    if(newPos.y <= upMax)
        {
        speed = -speed;
        movingUp = false;
        }
    if(newPos.y >= downMax)
        {
        speed = -speed;
        movingUp = true;
        }
    if(movingUp == true)
        {
        flip.YrotationU();
        }
    if(movingUp == false)
        {
        flip.YrotationD();
        }
    }
if(canMove == false)
    {
    MVect.y = 0f;
    }
if(pause.pauseOnOff == true)
    {
    canMove = false;
    }
if(pause.pauseOnOff == false)
    {
    canMove = true;
    }
if(player.Win == true)
    {
    canMove = false; 
    }
if(player.Lose == true)
    {
    canMove = false;
    }
//constrains enemy movemnet. Has to be set in editor

transform.position = newPos;
    }
}
