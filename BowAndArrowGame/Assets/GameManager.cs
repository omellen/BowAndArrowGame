using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject Cursor;
    public GameObject HealthBar;

    public static bool gameIsOver = false;

    void Start()
    {
        HealthBar.SetActive(true);
        Cursor.SetActive(true);
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
        Cursor.SetActive(false);
        GOPanel.SetActive(true);
    }
}
