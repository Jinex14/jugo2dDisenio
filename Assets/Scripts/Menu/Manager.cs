    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject pausa;

    
    private void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            pausa.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Unpause()
    {
        
        pausa.SetActive(false);
        Time.timeScale = 1;
            
    }

    public void BacToMenu()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
