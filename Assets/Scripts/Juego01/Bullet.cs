using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public bool up;

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
