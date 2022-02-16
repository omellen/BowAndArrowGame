using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private CreateEnemy eScript;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        eScript.InvokeRepeating("Spawn", 1, 1);
        GameManager.newGame = true;
    }

}
