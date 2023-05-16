using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mrSpiky : MonoBehaviour
{
    //[SerializeField] private AudioSource popEffect;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jezecek"))
        {
            OhNo();

        }

        if (collision.gameObject.CompareTag("Konec"))
        { 
            OhNo();
        }
    }

    private void OhNo()
    {
        //popEffect.Play();
        ItemCollector.bonbonky = ItemCollector.globalBonbonky;
        //int scene = SceneManager.GetActiveScene().buildIndex;
        RestartLevel();
        
    }

    private void RestartLevel()
    {
        //popEffect.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
