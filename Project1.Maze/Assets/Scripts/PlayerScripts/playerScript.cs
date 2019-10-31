using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
public Vector2 StartPos;
private float speed = .005f;
private Rigidbody2D rb2d;
//lives stuff
private int maxLives = 3;
private int curentLives;
public Text LifeCounter;

//Panel Stuff
[SerialiazedField]public GameObject WinPanel;
[SerialiazedField]public GameObject PausePanel;
[SerialiazedField]public GameObject LosePanel; 
    // Start is called before the first frame update
void Start()
    {
        transform.position = StartPos;
        
        rb2d = GetComponent<Rigidbody2D>();
        
        currentLives = 3;
        
        PausePanel.SetActive(false);
        WinPanel.SetActive(false);
        LosePanel.SetActive(false);
    }

    // Update is called once per frame
void Update()
    {
/////////Movement Controls/////////
        if(Input.GetKey(KeyCode.A))//move left
            {
            transform.Translate(Vector2.left * speed);
   /*rb2d.AddForce(-transform.right * speed * Time.deltaTime)*/; 
    }
        if(Input.GetKey(KeyCode.D))//move right
            {
            transform.Translate(Vector2.right * speed);
    /*rb2d.AddForce(transform.right * speed * Time.deltaTime)*/;
    }
        if(Input.GetKey(KeyCode.W))//move up
            {
            transform.Translate(Vector2.up * speed);
    /*rb2d.AddForce(transform.forward*speed * Time.deltaTime)*/;
    }
        if(Input.GetKey(KeyCode.S))//move down
            {
            transform.Translate(Vector2.down * speed);
    /*rb2d.AddForce(-transform.forward*speed * Time.deltaTime)*/;
    }
        if(Input.GetKeyDown(KeyCode.Escape))//pause key
            {
                if(!PausePanel.activeInHierarchy)//activates pause if it is not already active
                    {
                    PauseGame();
                    }
                if(PausePanel.activeInHierarchy)//deactivats pause if it is not already active
                    {
                    ConinueGame();
                    }
            }
/////////Uodating Lives///////////
        if(curentLives <= 0)//activates lose condition
            {
            LoseGame();
            }
        LifeCounter.text = (curentLives + " / " + maxLives);//Sets text in HUD to track Lives
    }
    
void OnCollisionEnter(Collision other)
    {
    if(other.gameobject.tag == "Goal")//activates win condition
        {
        WinGame();
        }
    }
    
private void PauseGame()//pauses game
    {
    Time.timeScale = 0;
    PausePanel.SetActive(true);
    }
    
private void ContinueGame()//unpauses game
    {
    Time.timeScale = 1;
    PausePanel.SetActive(false);
    }
    
private void WinGame()//pauses game and sets WinPanel Active
    {
    Time.timeScale = 0;
    WinPanel.SetActive(true);
    }
    
private void LoseGame()//pauses game and sets LosePanel Active
    {
    
    }
    
public void reset()//called for when player is in enemy trigger for 2 sec. Restes player at the begining of the lavel
    {
    curentLives -= 1;
    transform.position = StartPos;
    }
}
