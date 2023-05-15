using System.Collections;
using System.Collections.Generic;
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

        }

        if (collision.gameObject.CompareTag("Konec"))
        {
            //ItemCollector.bonbonky = ItemCollector.globalBonbonky;
            OhNo();
        }
    }

    private void OhNo()
    {
        ItemCollector.bonbonky = ItemCollector.globalBonbonky;
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
