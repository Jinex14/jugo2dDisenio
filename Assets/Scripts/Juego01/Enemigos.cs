using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private int itemCopies = 5;
    public Transform itemContainer;
    private int itemToSpawn;
    private float timeDelay = 0;
    private bool attack = false;
    private int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 1 * Time.deltaTime);
        timeDelay += Time.deltaTime;
        if (attack && timeDelay >= 1.5f)
        {
            timeDelay = 0;
            selectItem();
            itemContainer.GetChild(itemToSpawn).gameObject.SetActive(true);
            itemContainer.GetChild(itemToSpawn).transform.position = transform.position;
        }


    }

    private void OnBecameVisible()
    {
        attack = true;
    }

    private void OnBecameInvisible()
    {
        attack = false;
    }

    void SpawnItem()
    {
        for (int i = 0; i < itemCopies; i++)
        {
            GameObject item = Instantiate(prefab, itemContainer.position, Quaternion.identity);
            item.transform.parent = itemContainer;
            item.SetActive(false);
        }
    }

    void selectItem()
    {
        bool aux = true;
        int safe = 0;
        while (aux)
        {
            if (safe > itemContainer.childCount) break;
            itemToSpawn = safe;
            if (itemContainer.GetChild(itemToSpawn).gameObject.tag == "enemy")
            {
                if (itemContainer.GetChild(itemToSpawn).gameObject.activeSelf == false)
                {
                    aux = false;
                    break;
                }
            }
            safe++;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            collision.gameObject.SetActive(false);
            life--;
            if (life<= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
