using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject TargetCursor;
    public GameObject HealthBar;

    public static bool gameIsOver = false;

    void Start()
    {
        HealthBar.SetActive(true);
        TargetCursor.SetActive(true);
        GOPanel.SetActive(false);
    }

    void Update()
    {
        if (gameIsOver == true)
            Invoke("GameOver", 1);
    }

    public void GameOver()
    {
        HealthBar.SetActive(false);
        TargetCursor.SetActive(false);
        GOPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
    }

    public static bool isGameOver()
    {
        return gameIsOver;
    }
}
