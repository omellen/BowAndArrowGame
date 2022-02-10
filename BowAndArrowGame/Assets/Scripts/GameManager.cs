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
            Invoke("GameOver", 1);


    }

    public void GameOver()
    {
        //HealthBar.SetActive(false);
        //TargetCursor.SetActive(false);
        //GOPanel.SetActive(true);

        can.enabled = false;
        endscreen.enabled = true;

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

}
