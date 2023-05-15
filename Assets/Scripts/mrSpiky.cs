using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mrSpiky : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jezecek"))
        {
            
            //ItemCollector.bonbonky = ItemCollector.globalBonbonky;
            OhNo();
            return;

        }

        if (collision.gameObject.CompareTag("Konec"))
        {
            //ItemCollector.bonbonky = ItemCollector.globalBonbonky;
            OhNo();
            return;
        }
    }

    private void OhNo()
    {
        ItemCollector.bonbonky = ItemCollector.globalBonbonky;
        //int scene = SceneManager.GetActiveScene().buildIndex;
        RestartLevel();
        
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
