using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class endGame : MonoBehaviour
{
    [SerializeField] private Text vysledneScore;
    private void Start()
    {
        // mělo by končit
        BGAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
        if (ItemCollector.globalBonbonky == 0)
        {
            vysledneScore.text = "Skore: 0";
        }
        vysledneScore.text = "Skore: " + ItemCollector.globalBonbonky.ToString();
    }
    // Start is called before the first frame update
    public void EndGame()
    {

        Debug.Log("Quiting the game... ");
        Application.Quit();
    }

    public void RestartGame()
    {
        ItemCollector.globalBonbonky = 0;
        SceneManager.LoadScene(0);
    }

    
}
