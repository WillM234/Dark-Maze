using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
public bool pauseOnOff;
    // Start is called before the first frame update
void Start()
{
        
}

    // Update is called once per frame
public void Update()
{

}
public void PauseOn()
{
pauseOnOff = true;
}
public void PauseOff()
{
pauseOnOff = false;
}
}
