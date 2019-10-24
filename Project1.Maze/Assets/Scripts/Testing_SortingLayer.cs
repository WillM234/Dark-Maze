using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing_SortingLayer : MonoBehaviour
{
public const string Vis_Layer = "Visible";
public const string Nvis_Layer = "NotVisible";
private SpriteRenderer sRenderer;
public int sortingLOrder = 0; 
    // Start is called before the first frame update
    void Start()
    { 
    sRenderer = GetComponent<SpriteRenderer>();
    sRenderer.sortingLayerName = Nvis_Layer;
    }
    // Update is called once per frame
    void Update()
{
if(Input.GetKeyDown(KeyCode.Space))
    {
sRenderer.sortingLayerName = Vis_Layer;
    }
}
}
