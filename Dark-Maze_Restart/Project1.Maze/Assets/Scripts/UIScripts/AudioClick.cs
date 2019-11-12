using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour
{
public AudioSource AudioSource;
public AudioClip Click1;
public AudioClip Click2;
public int clipChooser;

public void PlayOnClick()
{
clipChooser = Random.Range(0,1);
    if(clipChooser == 0)
        {
        if(!AudioSource.isPlaying)
            {
            AudioSource.PlayOneShot(Click1);
            }
        }
    if(clipChooser == 1)
        {
        if(!AudioSource.isPlaying)
            {
            AudioSource.PlayOneShot(Click2);
            }
        }
}
}
