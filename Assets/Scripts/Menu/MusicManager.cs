using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource aSource;
    private void Awake()
    {
        aSource = GetComponent<AudioSource>();
        if(PlayerPrefs.GetInt("sound") == 1)
        {
            aSource.mute = true;
        }
    }
    
}
