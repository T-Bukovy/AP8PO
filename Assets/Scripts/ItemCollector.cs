using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public static int globalBonbonky = 0;
    public static int bonbonky = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bonbonek"))
        {
            Destroy(collision.gameObject);
            bonbonky++;
            Debug.Log("bonbonky " + bonbonky);
        }
        if (collision.gameObject.CompareTag("Zmrzlinka"))
        {
            Destroy(collision.gameObject);
            bonbonky += 5;
            Debug.Log("bonbonky " + bonbonky);
        }
        scoreText.text = "Skore: " + bonbonky;
    }

    private void Start()
    {
        scoreText.text = "Skore: " + globalBonbonky;
    }

}
