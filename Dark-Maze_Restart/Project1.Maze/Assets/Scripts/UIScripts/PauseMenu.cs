using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
public bool pauseOnOff;

public void PauseOn()
{
pauseOnOff = true;
}
public void PauseOff()
{
pauseOnOff = false;
}
}
