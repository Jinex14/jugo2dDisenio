using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pj : MonoBehaviour
{
    [SerializeField] private int aux;
    private Vector2 initPos = new Vector2(0.08f, -4.06f);
    [SerializeField] private GameObject prefab;
    public int itemCopies;
    public Transform itemContainer;
    private int itemToSpawn;
    [SerializeField] private Transform shootToSpawn;
    [SerializeField] private GameObject vid;
    private int life = 2;
    private float timeDelay = 0;
    private float delay = 0.5f;
    private bool inv = false;
    private Animator anim;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("player") ==aux)
        {
            transform.position = initPos;
            anim = GetComponent<Animator>();
            SpawnItem();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var pos = Input.mousePosition;
        pos.z = 10;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = Vector3.Lerp(transform.position, pos, 5 * Time.deltaTime);

        timeDelay += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && timeDelay>= delay)
        {
            timeDelay = 0;
            selectItem();
            itemContainer.GetChild(itemToSpawn).gameObject.SetActive(true);
            itemContainer.GetChild(itemToSpawn).transform.position = shootToSpawn.position;
        }
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
            if (itemContainer.GetChild(itemToSpawn).gameObject.tag == "Bullet")
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
        if(collision.tag == "enemy" && !inv)
        {
            collision.gameObject.SetActive(false);
            life--;
            StartCoroutine(damage());
            if(life < 2)
            {
                vid.SetActive(false);
            }
            if(life <= 0)
            {
                SceneManager.LoadScene("game_over", LoadSceneMode.Single);
            }
        }
        if (collision.name == "balas")
        {
            collision.gameObject.SetActive(false);
            delay = 0.25f;
        }

        if (collision.name == "vida")
        {
            collision.gameObject.SetActive(false);
            if (life == 1)
            {
                life++;
                vid.SetActive(true);
            }else
            {
                life++;
            }
        }
        if (collision.name == "escudo")
        {
            collision.gameObject.SetActive(false);
            StartCoroutine(timeShield());
        }

        if (collision.name == "meta")
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }

    private IEnumerator timeShield()
    {
        inv = true;
        anim.SetInteger("State1", 1);
        yield return new WaitForSeconds(1.5f);
        inv = false; 
        anim.SetInteger("State1", 0);
    }


    private IEnumerator damage()
    {
        inv = true;
        anim.SetInteger("State12", 1);
        yield return new WaitForSeconds(0.20f);
        inv = false;
        anim.SetInteger("State12", 0);
    }
}
