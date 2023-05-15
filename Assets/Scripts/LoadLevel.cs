using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Zde půjde zvuk portalu
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Zde zavolám zvuk portalu
            CompleteLevel();
        }
    }


    private void CompleteLevel()
    {
        ItemCollector.globalBonbonky = ItemCollector.bonbonky;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
