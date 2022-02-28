using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Canvas gameCanvas;
    public Canvas endscreen;
    public Canvas loadScreen;
    public Canvas Instructions;


    public static float count;

    public static bool gameIsOver = false;
    public static bool startNewGame = false;


    void Start()
    {
        gameCanvas.enabled = false;
        gameCanvas.gameObject.SetActive(false);
        endscreen.enabled = false;
        endscreen.gameObject.SetActive(false);
        loadScreen.enabled = true;
        loadScreen.gameObject.SetActive(true);
        Instructions.enabled = false;
        Instructions.gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameIsOver == true)
        {
            gameIsOver = false;
            Invoke("GameOver", 1);
        }

        if (startNewGame == true)
        {
            startNewGame = false;
            Invoke("StartGame", 1);
        }
    }

    public void GameOver()
    {
        gameCanvas.enabled = false;
        endscreen.enabled = true;
        endscreen.gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGame()
    {
        gameCanvas.enabled = true;
        gameCanvas.gameObject.SetActive(true);
        endscreen.enabled = false;
        endscreen.gameObject.SetActive(false);
        loadScreen.enabled = false;
        loadScreen.gameObject.SetActive(false);
        Instructions.enabled = false;
        Instructions.gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;

        GameObject.Find("CreatingThyEnemy").GetComponent<CreateEnemy>().enabled = true;
        GameObject.Find("CreatingThyEnemy").GetComponent<Timer>().enabled = true;
    }

    public static bool IsGameOver()
    {
        return gameIsOver;
    }




    public static void ReturnCount(float number)
    {
        count = number;
    }

    public void HowToPlay()
    {
        gameCanvas.enabled = false;
        gameCanvas.gameObject.SetActive(false);
        endscreen.enabled = false;
        endscreen.gameObject.SetActive(false);
        loadScreen.enabled = false;
        loadScreen.gameObject.SetActive(false);
        Instructions.enabled = true;
        Instructions.gameObject.SetActive(true);
    }

}
