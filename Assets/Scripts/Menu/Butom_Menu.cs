using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butom_Menu : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
