using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorUser : MonoBehaviour
{
    [SerializeField] private int aux;
    [SerializeField] private SpriteRenderer[] rd;
    private void OnMouseDown()
    {
        foreach(SpriteRenderer element in rd)
        {
            element.color = Color.white;
        }
        PlayerPrefs.SetInt("player", aux);
        rd[aux].color = Color.gray;
    }
}
