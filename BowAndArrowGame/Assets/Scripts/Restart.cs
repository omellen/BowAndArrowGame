using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public Canvas loadScreen;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        //eScript.InvokeRepeating("Spawn", 1, 1);
        GameManager.startNewGame = true;
        
    }

    public void LoadMainScreen()
    {
        loadScreen.enabled = true;
        loadScreen.gameObject.SetActive(true);
    }

}
