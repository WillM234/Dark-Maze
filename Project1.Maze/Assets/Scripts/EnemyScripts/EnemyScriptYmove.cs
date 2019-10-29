using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptYmove : MonoBehaviour
{
public float upMax;
public float downMax;
public float speed;

private Vector2 MVect;
    // Start is called before the first frame update
    void Start()
    {
MVect.y = -1f; 
    }

    // Update is called once per frame
    void Update()
    {
Vector2 newPos = new Vector2(transform.position.x + MVect.x * speed, transform.position.y + MVect.y * speed); 

//constrains enemy movemnet. Has to be set in editor
    if(newPos.y <= upMax)
        {
        speed = -speed;
        }
    if(newPos.y >= downMax)
        {
        speed = -speed;           
        }
transform.position = newPos;
    }
}
