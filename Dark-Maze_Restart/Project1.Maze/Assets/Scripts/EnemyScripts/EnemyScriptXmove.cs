using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptXmove : MonoBehaviour
{
public float leftMax;
public float rightMax;
public float speed;

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
    if(newPos.x <= leftMax)
        {
        speed = -speed;
        }
    if(newPos.x >= rightMax)
        {
        speed = -speed;           
        }
transform.position = newPos;
}
}
