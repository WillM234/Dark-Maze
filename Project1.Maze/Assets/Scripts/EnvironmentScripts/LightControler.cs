using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControler : MonoBehaviour
{
public List<Transform> Lights; 
public float Position; 
public float Strength;
public float Falloff; 

private void Update()
{
for (int i = 0; i < Lights.Count; i++)
    {
    Lights[i].position = Vector2.Lerp(transform.position, Position, Strength * (i Falloff));
    }
}
}
