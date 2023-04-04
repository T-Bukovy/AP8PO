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
            Debug.Log("You just touched my spiky spike ... now, please ... remove yourself :) ");
            OhNo();

        }

        if (collision.gameObject.CompareTag("Konec"))
        {
            OhNo();
        }
    }

    private void OhNo()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
