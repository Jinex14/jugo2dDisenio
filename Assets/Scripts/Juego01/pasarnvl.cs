using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pasarnvl : MonoBehaviour
{
    public AudioSource Win;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            Win.Play();
             SceneManager.LoadScene(5);
        }
    }
}
