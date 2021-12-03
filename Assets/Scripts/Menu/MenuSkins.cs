using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSkins : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("skin", LoadSceneMode.Single);
    }
}
