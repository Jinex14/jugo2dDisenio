using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtoms : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("juego", LoadSceneMode.Single);
    }
}
