using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteMusic : MonoBehaviour
{
    private AudioSource aSource;
    private bool aux = false;
    private void Awake()
    
    {
        aSource = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            aSource.mute = true;
            aux = true;
        }
    }
    private void OnMouseDown()
    {
        aux = !aux;
        aSource.mute = aux;
        if(aux) PlayerPrefs.SetInt("sound", 1);
        else PlayerPrefs.SetInt("sound", 0);
    }
}
