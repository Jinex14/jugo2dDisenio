using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButom : MonoBehaviour
{
    public GameObject Pausa;
    
    private void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            Pausa.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void Unpause()
    {
        Pausa.SetActive(false);
        Time.timeScale = 1;
    }
}
