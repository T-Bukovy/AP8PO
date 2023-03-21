using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    private object myPlat;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameObject[] fillings = G "Platform");

        //Debug.Log(fillings.Count());
        //var go = fillings.Select((value, index) => new { value, index }).OrderByDescending(vi => vi.value).First();
        //nutno předělat na lepší verzi ...   
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f),
            player.transform.position.y + (6 + Random.Range(0.6f,1f))), Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
