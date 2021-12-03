using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backGroundMove : MonoBehaviour
{
 
     void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 1 * Time.deltaTime);
    
    }
}