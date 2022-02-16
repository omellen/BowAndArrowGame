using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject TargetCursor;
    public GameObject HealthBar;

    public Canvas can;
    public Canvas endscreen;

    public Text ECounter;
    public static float count;

    public static bool gameIsOver = false;
    public static bool newGame = false;

    void Start()
    {
        //HealthBar.SetActive(true);
        //TargetCursor.SetActive(true);
        //GOPanel.SetActive(false);
        //ECounter.SetActive(false);

        can.enabled = true;
        endscreen.enabled = false;
    }

    void Update()
    {
        if (gameIsOver == true)
        {
            gameIsOver = false;
            Invoke("GameOver", 1);
        }
            

        if (newGame == true)
        {
            newGame = false;
            Invoke("ResetGame", 1);
        }
    }

    public void GameOver()
    {
        //HealthBar.SetActive(false);
        //TargetCursor.SetActive(false);
        //GOPanel.SetActive(true);

        can.enabled = false;
        endscreen.enabled = true;
        endscreen.gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
    }

    public static bool IsGameOver()
    {
        return gameIsOver;
    }

    public static void ReturnCount(float number)
    {
        count = number;
    }

    public void SetCount() {
        ECounter.text = "" + count;
    }

    public void ResetGame()
    {
        can.enabled = true;
        endscreen.enabled = false;

        endscreen.gameObject.SetActive(false);
        can.gameObject.SetActive(true);
    }

}
