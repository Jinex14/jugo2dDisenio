using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax1 : MonoBehaviour
{
    public float speed;
    private Renderer rnd;   
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        rnd=GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        rnd.material.mainTextureOffset = new Vector2(0,time);
    }
}
