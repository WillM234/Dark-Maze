using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptXmove : MonoBehaviour
{
public float xleftMax;
public float xrightMax;
public float speed;
 
public bool movingR;

public EnemyColliderFlip flip;//remember to set this in editor

private Vector2 MVect;
    // Start is called before the first frame update
    void Start()
    {
MVect.x = -1f;
    }

    // Update is called once per frame
    void Update()
{
//automates movement of enemy. Have to set min?max in editor 
Vector2 newPos = new Vector2(transform.position.x + MVect.x * speed, transform.position.y + MVect.y * speed); 


//constrains enemy movemnet. Has to be set in editor
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
transform.position = newPos;
}
}
