using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void EndGame()
    {

        Debug.Log("Quiting the game... ");
        Application.Quit();
    }
}
