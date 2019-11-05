using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Script : MonoBehaviour
{
//other scripts
public PauseMenu pause;
//random Stuff
public Vector2 StartPos;
private float speed = .005f;
private Rigidbody2D rb2d;
//lives stuff
private int maxLives = 3;
private int curentLives;
public Text LifeCounter;
//Panel Stuff
public GameObject WinPanel;
public GameObject PausePanel;
public GameObject LosePanel;
public GameObject HUD;
//bools for controls
public bool canMove;
public bool Lose;
public bool Win;
    // Start is called before the first frame update
void Start()
    {
        transform.position = StartPos;
        
        rb2d = GetComponent<Rigidbody2D>();
        
        curentLives = 3;
        
        PausePanel.SetActive(false);
        WinPanel.SetActive(false);
        LosePanel.SetActive(false);
    }
    // Update is called once per frame
void Update()
    {
    if(pause.pauseOnOff == false)//PauseMenu has to be inactive to use movement
    {
    canMove = true;
    PausePanel.SetActive(false);  
    }
    if(Win == true)//sets canMove fasle
        {
        canMove = false;
        }
    if(Lose == true)//sets canMove fasle
        {
        canMove = false;
        }
    if(canMove == true)//enables movement
        {
        /////////Movement Controls/////////
         if(Input.GetKey(KeyCode.A))//move left
            {
            transform.Translate(Vector2.left * speed); 
            }
        if(Input.GetKey(KeyCode.D))//move right
            {
            transform.Translate(Vector2.right * speed);
            }
        if(Input.GetKey(KeyCode.W))//move up
            {
            transform.Translate(Vector2.up * speed);
            }
        if(Input.GetKey(KeyCode.S))//move down
            {
            transform.Translate(Vector2.down * speed);
            }
            HUD.SetActive(true);
        }
    if(Input.GetKeyDown(KeyCode.P))//activates pause menu
        {
        pause.PauseOn();
        }
    if(pause.pauseOnOff == true)
        {
        canMove = false;
        PausePanel.SetActive(true);
        }
    if(canMove == false)//sets HUD off when a menu is open.
        {
        HUD.SetActive(false);
        }
/////////Updating Lives///////////
    if(curentLives <= 0)//activates lose condition
        {
            LoseGame();
            }
    LifeCounter.text = ("Lives: " + curentLives + " / " + maxLives);//Sets text in HUD to track Lives
    }   
void OnCollisionEnter2D(Collision2D other)
    {
    if(other.gameObject.tag == "Goal")//activates win condition
        {
        WinGame();
        }
    }
public void WinGame()//pauses game and sets WinPanel Active
    {
    WinPanel.SetActive(true);
    Win = true;
    }   
public void LoseGame()//pauses game and sets LosePanel Active
    {
    LosePanel.SetActive(true);
    Lose = true;
    } 
public void reset()//called for when player is in enemy trigger for 2 sec. Restes player at the begining of the lavel
    {
    canMove = true;
    curentLives -= 1;
    transform.position = StartPos;
    }
}
